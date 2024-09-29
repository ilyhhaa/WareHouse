using Microsoft.EntityFrameworkCore;
using WareHouse.Models;

namespace WareHouse.Data
{
    public class StorageContext:DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options):base (options) { }

        public DbSet<StorageModel> Storages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    
}
