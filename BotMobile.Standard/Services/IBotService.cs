using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bot.Connector.DirectLine;

namespace BotMobile.Services
{
    public interface IBotService
    {
        Task<string> StartConversationAsync();
        Task SendMessageAsync(string conversationId, string message);
        Task<IEnumerable<Activity>> GetMessageAsync(string conversationId, string watermark);
    }
}
