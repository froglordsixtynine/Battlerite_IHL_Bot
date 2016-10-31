using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHLBot.Config
{
    internal class Credentials
    {
        //public string Username = "sampleemail@email.com";
        //public string Password = "mypassword";
        public string Token = Constants.Token;
        public ulong BotId = Constants.BotId;
        public ulong[] OwnerIds = { 000000000000 };
    }
}
