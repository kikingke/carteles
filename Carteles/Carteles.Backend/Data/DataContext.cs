using Carteles.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carteles.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

    }
}
