using PRTelegramBot.Attributes;
using PRTelegramBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Npgsql;

namespace TechnogramBot
{
    public class main
    {
        [ReplyMenuHandler("ку")]
        public static async Task ky(ITelegramBotClient botClient, Update update)
        {
            string slonyara = "Host=localhost;Username=postgres;Password=TtHWz9;Database=telegrambotik";
            string zapros = "SELECT * FROM test1";

            NpgsqlConnection connection = new NpgsqlConnection(slonyara);
            await connection.OpenAsync();

            NpgsqlCommand command = new NpgsqlCommand(zapros, connection);

            NpgsqlDataReader reader = await command.ExecuteReaderAsync();

            string message = "текст с базы данных:";

            while (await reader.ReadAsync())
            {
                string testValue = reader.GetString(1);
                message += testValue + "\n";
            }

            var option = new OptionMessage();
            option.Message = message;

            await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);



            connection.Close();
        }
    }
}
