using Microsoft.EntityFrameworkCore;
using UI_MVC.Models.Entities;

namespace UI_MVC.Models.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Person> People { get; set; }
    }
}
