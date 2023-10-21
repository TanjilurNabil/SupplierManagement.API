using SupplierManagement.API.Models.Domain;

namespace SupplierManagement.API.Repositories.Interface
{
    public interface IBrandRepository
    {
        Task<Brand> CreateAsync(Brand brand);
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand?> GetByIdAsync(Guid id);
    }
}
