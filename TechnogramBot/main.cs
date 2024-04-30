using PRTelegramBot.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TechnogramBot
{
    public class main
    {
        [ReplyMenuHandler("привет")]
        public static async Task Commands(ITelegramBotClient botClient, Update update) 
        {
            var msg = "иди нахуй";
            var sendmsg = await PRTelegramBot.Helpers.Message.Send(botClient , update, msg);
        }
    }
}
