using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace IHLBot.Utils
{
    internal class Utils
    {
        public static void LoadConfig(Bot bot)
        {
            try
            {
                if (!Directory.Exists(Constants.PathPrefix))
                    Directory.CreateDirectory(Constants.PathPrefix);
                if(!File.Exists(Constants.ConfigFile))
                    File.WriteAllText(Constants.ConfigFile, JsonConvert.SerializeObject(new Config.Configuration(), Formatting.Indented));
            }
            catch
            {
                Console.WriteLine($"Failed to write new config file. ({Constants.ConfigFile})");
            }

            try
            {
                bot.Configuration = JsonConvert.DeserializeObject<Config.Configuration>(File.ReadAllText(Constants.ConfigFile));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to load config file. ({Constants.ConfigFile})");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public static void LoadCredentials(Bot bot)
        {
            try
            {
                if (!Directory.Exists(Constants.PathPrefix))
                    Directory.CreateDirectory(Constants.PathPrefix);
                if (!File.Exists(Constants.CredentialsFile))
                    File.WriteAllText(Constants.CredentialsFile, JsonConvert.SerializeObject(new Config.Credentials(), Formatting.Indented));
            }
            catch
            {
                Console.WriteLine($"Failed to write new credentials file. ({Constants.CredentialsFile})");
            }

            try
            {
                bot.Credentials = JsonConvert.DeserializeObject<Config.Credentials>(File.ReadAllText(Constants.CredentialsFile));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to load credentials file. ({Constants.CredentialsFile})");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
