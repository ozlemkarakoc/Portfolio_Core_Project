using Microsoft.EntityFrameworkCore;
using Portfolio_Core_Project_API.DAL.Entity;

namespace Portfolio_Core_Project_API.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; database=PortfolioCoreDb_API; integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
