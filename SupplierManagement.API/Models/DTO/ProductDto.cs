using SupplierManagement.API.Models.Domain;

namespace SupplierManagement.API.Models.DTO
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductNameBn { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public bool IsActive { get; set; }
        public BrandDto Brand { get; set; } //It should take brandDTo
    }
}
