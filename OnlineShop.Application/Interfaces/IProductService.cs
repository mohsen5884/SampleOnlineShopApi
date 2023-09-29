using OnlineShop.Infrastructure.Dtos;

namespace OnlineShop.Application.Interfaces;

public interface IProductService
{
    List<ProductDto> GetAll();
    ProductDto Get(int id);
    ProductDto Add(ProductDto modle);
}
