using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bot.Connector.DirectLine;

namespace BotMobile.Services
{
    class BotService : IBotService
    {
        private static string BotUserName { get; } = "TSBot01";
        private IDirectLineClient DirectLineClient { get; }

        public BotService(IDirectLineClient directLineClient)
        {
            this.DirectLineClient = directLineClient;
        }

        public Task<IEnumerable<Activity>> GetMessageAsync(string conversationId, string watermark)
        {
            throw new NotImplementedException();
        }

        public async Task SendMessageAsync(string conversationId, string message)
        {
            await this.DirectLineClient.Conversations.PostActivityAsync(
                conversationId: conversationId,
                activity: new Activity
                {
                    From = new ChannelAccount(BotUserName),
                    Text = message,
                    Type = ActivityTypes.Message,
                });
        }

        public async Task<string> StartConversationAsync()
        {
            var conversation = await this.DirectLineClient.Conversations.StartConversationAsync();
            return conversation.ConversationId;
        }
    }
}
