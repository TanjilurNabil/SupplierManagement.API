namespace SupplierManagement.API.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductNameBn { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public bool IsActive { get; set; }
        public Brand Brand { get; set; }
    }
}
