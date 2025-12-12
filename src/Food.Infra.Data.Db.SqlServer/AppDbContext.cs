using Food.Core.Domain.Model.Emtities;
using Microsoft.EntityFrameworkCore;

namespace Food.Infra.Data.Db.SqlServer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Restaurant> Restaurants { get; set; }
    }
}