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

namespace TechnogramBot.Menu
{
    public class ButtonMenu
    {
        [ReplyMenuHandler("/start")]
        public static async Task Menu(ITelegramBotClient botClient, Update update)
        {
            var user = update.Message.From;
            var userName = $"{user.FirstName}";

            var message = $"Привет {userName}! Рад видеть тебя. \n\t\t\t\t\t\t\t\t\t\t\tСкажи , ты новичок?";
            var menuList = new List<KeyboardButton>();

            menuList.Add("Да");
            menuList.Add("Нет");

            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }

        [ReplyMenuHandler("да", "/help")]
        public static async Task New(ITelegramBotClient botClient, Update update)
        {
            var message = "Выберите интересующий вас вопрос";
            var menuList = new List<KeyboardButton>();

            menuList.Add("Доступы к инструментам");
            menuList.Add("Регламенты");
            menuList.Add("Испытательный срок");

            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }
        [ReplyMenuHandler("нет", "/old")]
        public static async Task old(ITelegramBotClient botClient, Update update)
        {
            var message = "Выбери блок, по которому у тебя возник вопрос \n/hr - Адаптация, Обучение, Перф, Командировка, Увольнение. \n/service - Больничный Отпуск Отпуск за свой счет Командировка Выплаты (зарплата, больничный, отпускные) Заказ справок в бухгалтерии Изменение персональных данных, рождение ребенка. \n/care - ДМС, бенефиты, выгорание, конфликтная ситуация.";
            var menuList = new List<KeyboardButton>();

            menuList.Add("/hr");
            menuList.Add("/service");
            menuList.Add("/саге");

            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }
    }
}
