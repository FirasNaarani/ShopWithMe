using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShopWithMe.Hubs_Service
{
    public class Shopping:Hub
    {
        public async override Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("UserConnected", Context.ConnectionId);
        }
        public async Task AddToGroup(string groupName,string connectionId)
        {
            await Groups.AddToGroupAsync(connectionId, groupName);
            Console.WriteLine(connectionId+" was added to group "+groupName);
        }
    }
}
