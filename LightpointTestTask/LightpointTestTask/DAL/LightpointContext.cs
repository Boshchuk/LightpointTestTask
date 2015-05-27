using System.Data.Entity;
using LightpointTestTask.Models;

namespace LightpointTestTask.DAL
{
    public class LightpointContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}