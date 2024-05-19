using PRTelegramBot.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using PRTelegramBot.Interface;
using PRTelegramBot.InlineButtons;
using PRTelegramBot.Utils;
using PRTelegramBot.Models;

namespace TechnogramBot.Commands
{
    public class AccessToTools
    {
        [ReplyMenuHandler("Доступы к инструментам")]
        public static async Task Inline(ITelegramBotClient botClient, Update update)
        {
            var message = "Выберите что вам необходимо";
            var menu = new List<IInlineContent>();

            menu.Add(new InlineURL("Welcome book", "https://vc.ru/hr/804410-onbording-sotrudnikov-vykladyvayu-nash-glavnyy-dokument-welcomebook#:~:text=Welcomebook%20"));
            menu.Add(new InlineURL("Wifi,VPN", "https://ru.wikipedia.org/wiki/VPN"));
            menu.Add(new InlineURL("Zoom", "https://ru.wikipedia.org/wiki/Zoom"));
            menu.Add(new InlineURL("YouTrack", "https://ru.wikipedia.org/wiki/YouTrack"));
            menu.Add(new InlineURL("GitLab", "https://ru.wikipedia.org/wiki/GitLab"));
            menu.Add(new InlineURL("Обзор HelpDesk", "https://okdesk.ru/blog/chto-takoe-help-desk"));

            var menuItems = MenuGenerator.InlineKeyboard(1,menu);
            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menuItems;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);


        }
    }
}
