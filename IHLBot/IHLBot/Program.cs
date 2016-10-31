using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHLBot.Utils;

namespace IHLBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Bot bot = new Bot();
            Utils.Utils.LoadConfig(bot);
            Utils.Utils.LoadCredentials(bot);
            bot.Connect();
        }
    }
}
