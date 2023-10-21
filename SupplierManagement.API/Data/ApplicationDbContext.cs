using Microsoft.EntityFrameworkCore;
using SupplierManagement.API.Models.Domain;

namespace SupplierManagement.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
