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
    public class Regulations
    {
        [ReplyMenuHandler("Регламенты")]
        public static async Task Inline(ITelegramBotClient botClient, Update update)
        {
            var message = "Выберите что вам необходимо";
            var menu = new List<IInlineContent>();

            menu.Add(new InlineURL("ЛНА", "https://ru.wikipedia.org/wiki/Локальный_нормативный_акт"));
            

            var menuItems = MenuGenerator.InlineKeyboard(1, menu);
            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menuItems;
            var sendMessag = await PRTelegramBot.Helpers.Message.Send(botClient, update, message, option);


        }
    }
}
