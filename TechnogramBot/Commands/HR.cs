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
using TechnogramBot.DataBase;


namespace TechnogramBot.Commands
{
    public class Hr
    {
        [ReplyMenuHandler("HR-менеджмент")]
        public static async Task HRSection(ITelegramBotClient botClient, Update update)
        {
            NpgsqlConnection connection = new NpgsqlConnection(Сonfig.connection);
            await connection.OpenAsync();

            NpgsqlCommand command = new NpgsqlCommand(Сonfig.request, connection);

            NpgsqlDataReader reader = await command.ExecuteReaderAsync();

            string message = "текст с базы данных: ";

            while (await reader.ReadAsync())
            {
                string test = reader.GetString(1);
                message += test + "\n";
            }

            var option = new OptionMessage();
            option.Message = message;

            await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);

            connection.Close();
        }
    }
}
