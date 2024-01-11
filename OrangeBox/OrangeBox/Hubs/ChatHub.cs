using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OrangeBox.Data; // Assuming your DbContext is in this namespace
using OrangeBox.Models;

namespace OrangeBox.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatContext _dbContext;

        public ChatHub(ChatContext dbContext)
        {
            _dbContext = dbContext;
        }


        // You can also create a method to retrieve messages
        public Task BroadcastMessage(Message messages) =>
        Clients.All.SendAsync("broadcastMessage", messages);
    }
}
