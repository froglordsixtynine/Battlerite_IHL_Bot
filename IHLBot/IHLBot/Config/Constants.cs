using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using System.IO;

namespace IHLBot
{
    internal static class Constants
    {
        public const string PathPrefix = @"IHLBot";
        public static readonly string ConfigFile = Path.Combine(PathPrefix, @"config.json");
        public static readonly string CredentialsFile = Path.Combine(PathPrefix, @"credentials.json");

        // Default credentials
        public const string Token = "MjQyNzE4MzExMzY2Nzg3MDcz.Cvk6NQ.CNM9PY5iF1TORLMsk3dUvw9K93k";
        public const ulong BotId = 0;

        // DiscordConfigBuilder constants
        public const string AppName = @"Battlerite NA IHL Bot";
        public const string AppVersion = "0.1.0";
        public const int ConnectionTimeout = 120000;
        public const LogSeverity LogLevel = LogSeverity.Warning;
        public const int MessageCacheSize = 10;
        public const int ReconnectDelay = 1000;
        public const int FailedReconnectDelay = 5000;

        // CommandServiceConfigBuilder constants
        public const bool AllowMentionPrefix = true;
        public const HelpMode CommandHelpMode = HelpMode.Public;
    }
}
