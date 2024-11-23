using Project.WMS.Product.WebAPI.Services.gRPC;
using Project.WMS.Stock.Models;

namespace Project.WMS.Stock.Services.gRPC
{
    public interface IProductGrpcService
    {
        Task<ProductDTO> Get();
    }

    public class ProductGrpcService : IProductGrpcService
    {
        private readonly Product.WebAPI.Services.gRPC.Product.ProductClient _productGrpcClient;

        public ProductGrpcService(Product.WebAPI.Services.gRPC.Product.ProductClient productGrpcClient)
        {
            _productGrpcClient = productGrpcClient;
        }

        public async Task<ProductDTO> Get()
        {
            var response = await _productGrpcClient.GetAsync(new GetProductRequest());

            return MapProductReponseToProductDTO(response);
        }

        private ProductDTO MapProductReponseToProductDTO(ProductResponse product)
        {
            return new ProductDTO(
                    product.Name,
                    product.Description,
                    (decimal)product.Price,
                    product.Disabled is not null ? product.Disabled.ToDateTime() : null
                );
        }
    }
}
