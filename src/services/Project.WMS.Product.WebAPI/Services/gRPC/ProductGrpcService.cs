using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Project.WMS.Product.WebAPI.Services.gRPC
{
    public class ProductGrpcService : Product.ProductBase
    {
        private readonly ILogger<ProductGrpcService> _logger;

        public ProductGrpcService(ILogger<ProductGrpcService> logger)
        {
            _logger = logger;
        }

        public override async Task<ProductResponse> Get(GetProductRequest request, ServerCallContext context)
        {
            var random = new Random();

            // todo: find database
            var product = new Entities.Product($"Product", "Description", Math.Round((decimal)(random.NextDouble() * 100), 2));

            var response = product ?? new Entities.Product("Product default", "Description default", 0.1m);

            return MapProductToProductResponse(response);
        }

        private ProductResponse MapProductToProductResponse(Entities.Product product)
        {
            return new ProductResponse()
            {
                Name = product.Name,
                Description = product.Description,
                Price = (double)product.Price,
                Created = Timestamp.FromDateTime(product.Created),
                Disabled = product.Disabled.HasValue ? Timestamp.FromDateTime(product.Disabled.Value) : null,
            };
        }
    }
}
