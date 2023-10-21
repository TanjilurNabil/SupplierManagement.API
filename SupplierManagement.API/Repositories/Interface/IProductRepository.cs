using SupplierManagement.API.Models.Domain;

namespace SupplierManagement.API.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
    }
}
