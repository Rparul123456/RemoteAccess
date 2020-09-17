using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RemoteServerAccess.Bot
{
    public class TeamConnector
    {
        //public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        //{
        //    var userAccount = new ChannelAccount(name: "Larry", id: "@UV357341");
        //    var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
        //    //var conversationId = await connector.Conversations.CreateDirectConversationAsync(botAccount, userAccount);

        //    Activity reply = activity.CreateReply($"You sent {activity.Text} which was {5} characters");

           
        //    await connector.Conversations.ReplyToActivityAsync(reply);
        //}
    }
}
