using PRTelegramBot.Attributes;
using PRTelegramBot.Models;
using PRTelegramBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace TechnogramBot
{
    public class ButtonMenu
    {
        [ReplyMenuHandler("Меню")]
        public static async Task Menu(ITelegramBotClient botClient, Update update)
        {
            var message = "Menu";

            var menuList = new List<KeyboardButton>();


            menuList.Add("1");
            menuList.Add("2");
            menuList.Add("3");
            menuList.Add("4");
            menuList.Add("5");
            menuList.Add("6");

            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }
    }
}
