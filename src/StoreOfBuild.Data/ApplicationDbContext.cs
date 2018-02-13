using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain.Product;

namespace StoreOfBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categorois {get; set;}
    }
}