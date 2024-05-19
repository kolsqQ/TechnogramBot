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

namespace TechnogramBot.Commands
{
    public class ProbationPeriod
    {
        [ReplyMenuHandler("Испытательный срок")]
        public static async Task Inline(ITelegramBotClient botClient, Update update)
        {
            var message = "Выберите что вам необходимо";
            var menu = new List<IInlineContent>();

            menu.Add(new InlineURL("Про ИС", "https://ru.wikipedia.org/wiki/Испытательный_срок_(трудовое_право)"));
            menu.Add(new InlineURL("Адаптационные мероприятия", "https://ru.wikipedia.org/wiki/Адаптация_персонала"));

            var menuItems = MenuGenerator.InlineKeyboard(1, menu);
            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menuItems;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);


        }
    }
}
