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

        [ReplyMenuHandler("да", "/new")]
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
        [ReplyMenuHandler("нет", "/help")]
        public static async Task old(ITelegramBotClient botClient, Update update)
        {
            var message = "Выбери блок, по которому у тебя возник вопрос " +
                "\n/hr - Адаптация, Обучение, Перф, Командировка, Увольнение. " +
                "\n/service - Больничный Отпуск Отпуск за свой счет Командировка Выплаты (зарплата, больничный, отпускные) Заказ справок в бухгалтерии Изменение персональных данных, рождение ребенка. " +
                "\n/care - ДМС, бенефиты, выгорание, конфликтная ситуация. " +
                "\n/office - Адреса офисов, СКД, доступ на парковку, питание, Приобретение техники на рабочее место, Настройка доступа к принтеру, телефония, Проблемы с доступом к учетной записи, Проблемы с доступом к VPN, Проблемы с доступом." +
                "\n/service - Больничный, Отпуск, Отпуск за свой счет, Компенсация за отпуск, Командировка, Выплаты (зарплата, больничный, отпускные), Заказ справок в бухгалтерии, Изменение персональных данных, рождение ребенка, Увольнение" +
                "\n/feedback - Обратная связь" +
                "\n/news - Поделиться новостью" +
                "\n/new - Часто задаваемые вопросы новыми сотрудниками";


            var menuList = new List<KeyboardButton>();

            menuList.Add("HR-менеджмент");
            menuList.Add("Сервис");
            menuList.Add("/саге");
            menuList.Add("Офис");
            menuList.Add("Сервис");
            menuList.Add("Обратная связь");
            menuList.Add("Поделиться новостью");

            var menu = MenuGenerator.ReplyKeyboard(2, menuList);

            var option = new OptionMessage();
            option.MenuReplyKeyboardMarkup = menu;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);
        }
    }
}
