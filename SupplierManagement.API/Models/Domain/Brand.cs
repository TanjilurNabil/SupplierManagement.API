namespace SupplierManagement.API.Models.Domain
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public string BrandNameBn { get; set; }
        public string Origin { get; set; }
        public string Manufacturer { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
