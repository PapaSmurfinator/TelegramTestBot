using Microsoft.EntityFrameworkCore;
using TelegramTestBot.Extended;
using TelegramTestBot.Models;

namespace TelegramTestBot.DbService
{
    public class OrderContext : DbContext
    {
        public DbSet<ExtendedOrder> ExtendedOrders { get; set; }
        public DbSet<User> Users { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public OrderContext() : base()
        {

        }
    }
}
