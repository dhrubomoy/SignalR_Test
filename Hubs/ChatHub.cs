using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Test.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void Whassup()
        {
            Clients.All.sayWhassup($"{Context.ConnectionId} says: <h1>Whassup</h1><hr>");
        }

    }
}
