using SupplierManagement.API.Data;
using SupplierManagement.API.Models.Domain;
using SupplierManagement.API.Repositories.Interface;

namespace SupplierManagement.API.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Product> CreateAsync(Product product)
        {
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
            return product;
        }
    }
}
