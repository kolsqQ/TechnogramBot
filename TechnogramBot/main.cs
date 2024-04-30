using PRTelegramBot.Attributes;
using PRTelegramBot.InlineButtons;
using PRTelegramBot.Interface;
using PRTelegramBot.Models;
using PRTelegramBot.Models.CallbackCommands;
using PRTelegramBot.Models.InlineButtons;
using PRTelegramBot.Utils;
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


        [ReplyMenuHandler("Меню")]
        public static async Task Menu(ITelegramBotClient botClient, Update update)
        {
            var message = "Меню";

            var menuListString = new List<string>();

            menuListString.Add("Привет");
            menuListString.Add("Пока");

            var menu = MenuGenerator.ReplyKeyboard(2, menuListString);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;

            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }

        [ReplyMenuHandler("Привет")]
        public static async Task privet(ITelegramBotClient botClient, Update update)
        {
            var message = "Привет ботиха";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

        [ReplyMenuHandler("Пока")]
        public static async Task poka(ITelegramBotClient botClient, Update update)
        {
            var message = "Пока ботиха";
            var sendMessage = await PRTelegramBot.Helpers.Message.Send(botClient, update, message);
        }

    }
}
