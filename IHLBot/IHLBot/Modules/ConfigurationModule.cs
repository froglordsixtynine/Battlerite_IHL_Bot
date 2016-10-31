using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Modules;

namespace IHLBot.Modules
{
    internal class ConfigurationModule : Module
    {
        public ConfigurationModule()
        {

        }

        public override String Prefix
        {
            get
            {
                return "!admin";
            }
        }

        public override void Install(ModuleManager manager)
        {
            throw new NotImplementedException();
        }
    }
}
