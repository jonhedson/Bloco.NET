using DemoAuthWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAuthWebAPI.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { set; get; }
        public DbSet<User> Users { get; set; }
    }
}
