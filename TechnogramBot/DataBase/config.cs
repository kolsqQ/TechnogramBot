using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnogramBot.DataBase
{
    public class Сonfig
    {
        public static string connection { get; set; } = "Host=localhost;Username=postgres;Password=123;Database=Bot";
        public static string request { get; set; } = "SELECT * FROM News";
    }
}
