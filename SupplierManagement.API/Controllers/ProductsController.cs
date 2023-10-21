using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplierManagement.API.Models.Domain;
using SupplierManagement.API.Models.DTO;
using SupplierManagement.API.Repositories.Interface;

namespace SupplierManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IBrandRepository brandRepository;

        public ProductsController(IProductRepository productRepository, IBrandRepository brandRepository)
        {
            this.productRepository = productRepository;
            this.brandRepository = brandRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequestDto request)
        {
            //Convert DTO to Domain
            var product = new Product
            {
                ProductName = request.ProductName,
                ProductNameBn = request.ProductNameBn,
                BasePrice = request.BasePrice,
                Description = request.Description,
                IsActive = request.IsActive,
                Brand = new Brand()
            };
            product.Brand = await brandRepository.GetByIdAsync(request.Brand);

            product = await productRepository.CreateAsync(product);
            if (product == null)
            {
                return NotFound();
            }
            var response = new ProductDto
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductNameBn = product.ProductNameBn,
                BasePrice = product.BasePrice,
                Description = product.Description,
                IsActive = product.IsActive,
                Brand = new BrandDto
                { Id = product.Brand.Id, BrandName = product.Brand.BrandName, BrandNameBn = product.Brand.BrandNameBn, Manufacturer = product.Brand.Manufacturer, Origin = product.Brand.Origin, IsActive = product.Brand.IsActive }
            };
            return Ok(response);
        }
    }
}
