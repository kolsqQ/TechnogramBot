using PRTelegramBot.Core;

const string zxc = "exit";

var bot = new PRBot(option =>
{
    option.Token = "6777113007:AAEFNCFVMHEylnlI-4XNswnOVOGMi0VIp3E";
    option.ClearUpdatesOnStart = true;
    option.Admins = new List<long>() { };
    option.BotId = 0;
});

bot.OnLogCommon += Telegram_OnLogCommon;
bot.OnLogError += Telegram_OnLogError;

await bot.Start();

void Telegram_OnLogError(Exception ex, long? id)
{
    Console.ForegroundColor = ConsoleColor.Red;
    string errorMsg = $"{DateTime.Now}:{ex}";
    Console.WriteLine(errorMsg);
    Console.ResetColor();
}

void Telegram_OnLogCommon(string msg, Enum typeEvent, ConsoleColor color)
{
    Console.ForegroundColor = ConsoleColor.Green;
    string message = $"{DateTime.Now}:{msg}";
    Console.WriteLine(message);
    Console.ResetColor();
}

while (true)
{
    var result = Console.ReadLine();
    if (result.ToLower() == zxc)
    {
        Environment.Exit(0);
    }
}

