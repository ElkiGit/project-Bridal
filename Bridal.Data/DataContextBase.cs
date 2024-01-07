using Bridal.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bridal.Data
{
    public class DataContextBase: DbContext
    {
        public DbSet<BridalClass> Bridal { get; set; }
        public DbSet<Dressmaker> Dressmaker { get; set; }
        public DbSet<QueueBridal> QueueBridal { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Bridal_DB");
        }
    }
}