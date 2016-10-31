using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace IHLBot.Utils
{
    internal class DiscordUtils
    {
        public static DiscordClient createClient()
        {
            var client = new DiscordClient(new DiscordConfigBuilder()
            {
                AppName = Constants.AppName,
                AppVersion = Constants.AppVersion,
                ConnectionTimeout = Constants.ConnectionTimeout,
                LogHandler = (s, e) =>
                    Console.WriteLine($"Severity: {e.Severity}" +
                                      $"Message: {e.Message}" +
                                      $"ExceptionMessage: {e.Exception?.Message ?? "None"}"),
                LogLevel = Constants.LogLevel,
                MessageCacheSize = Constants.MessageCacheSize,
                ReconnectDelay = Constants.ReconnectDelay,
                FailedReconnectDelay = Constants.FailedReconnectDelay,
            });
            return client;
        }

        public static CommandService createCommandService()
        {
            var service = new CommandService(new CommandServiceConfigBuilder()
            {
                AllowMentionPrefix = Constants.AllowMentionPrefix,
                CustomPrefixHandler = m=>0,
                HelpMode = Constants.CommandHelpMode,
                ErrorHandler = async (s, e) =>
                {
                    if (e.ErrorType != CommandErrorType.BadPermissions)
                        return;
                    if (string.IsNullOrWhiteSpace(e.Exception?.Message))
                        return;
                    try
                    {
                        await e.Channel.SendMessage(e.Exception.Message).ConfigureAwait(false);
                    }
                    catch { }
                },
            });
            return service;
        }
    }
}
