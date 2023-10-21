using SupplierManagement.API.Models.Domain;

namespace SupplierManagement.API.Models.DTO
{
    public class BrandDto
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public string BrandNameBn { get; set; }
        public string Origin { get; set; }
        public string Manufacturer { get; set; }
        public bool IsActive { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
