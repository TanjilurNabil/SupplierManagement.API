using Microsoft.EntityFrameworkCore;
using SupplierManagement.API.Data;
using SupplierManagement.API.Models.Domain;
using SupplierManagement.API.Repositories.Interface;

namespace SupplierManagement.API.Repositories.Implementation
{
    public class BrandRepository:IBrandRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BrandRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Brand> CreateAsync(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Brand>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Brand?> GetByIdAsync(Guid id)
        {
            return await dbContext.Brands.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
