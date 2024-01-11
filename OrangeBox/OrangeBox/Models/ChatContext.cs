using Microsoft.EntityFrameworkCore;
using OrangeBox.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace OrangeBox.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
        }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define any additional model configurations here if needed
        }

        // Additional DbSet properties for other entities can be added here
    }
}
