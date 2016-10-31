using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.Modules;

namespace IHLBot
{
    public class Bot
    {
        public DiscordClient Client;
        public Config.Credentials Credentials;
        public Config.Configuration Configuration;

        public Bot()
        {
            Client = Utils.DiscordUtils.createClient();
            Client.AddService<CommandService>(Utils.DiscordUtils.createCommandService());
            var modules = Client.AddService<ModuleService>(new ModuleService());
        }

        public void Connect()
        {
            Client.ExecuteAndWait(async () =>
            {
                try
                {
                    await Client.Connect(Credentials.Token, TokenType.Bot).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Token is wrong. Login failed.");
                    Console.WriteLine(e.ToString());
                    Console.ReadKey();
                    return;
                }

            });
        }
    }
}
