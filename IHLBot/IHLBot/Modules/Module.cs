using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Modules;
using Discord.Commands;

namespace IHLBot.Modules
{
    internal abstract class Module : IModule
    {
        public abstract void Install(ModuleManager manager);

        public abstract string Prefix { get; }
    }
}
