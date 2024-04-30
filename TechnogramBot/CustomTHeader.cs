using PRTelegramBot.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnogramBot
{
    [InlineCommand]
    public enum CustomTHeader
    {
        ExampleOne = 100,
        ExampleTwo,
        ExampleThree,
        CustomPage,
        Favorite
    }
}
