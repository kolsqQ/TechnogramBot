using PRTelegramBot.Attributes;
using PRTelegramBot.InlineButtons;
using PRTelegramBot.Interface;
using PRTelegramBot.Models;
using PRTelegramBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace TechnogramBot.Commands
{
    public class Service
    {
        [ReplyMenuHandler("Сервис")]
        public static async Task ServiseSection(ITelegramBotClient botClient, Update update)
        {
            var message = "Выберите интересующий вас вопрос";
            var menuList = new List<KeyboardButton>();

            // menuList.Add(из бд взять категории );
            menuList.Add("Вернуться к главному меню");
            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }
    }
}
