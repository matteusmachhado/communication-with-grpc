using Microsoft.AspNetCore.Mvc;
using Project.WMS.Stock.Services.gRPC;
using Project.WMS.WebAPI.Core.Controllers;
using Projetct.WMS.Core.Interfaces;

namespace Project.WMS.Stock.Controllers
{
    [Route("api/product")]
    public class ProductController : MainController
    {
        private readonly IProductGrpcService _productGrpcService;

        public ProductController(IProductGrpcService productGrpcService,
            INotificationService notificationService) : base (notificationService)
        {
            _productGrpcService = productGrpcService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _productGrpcService.Get();

            return CreateResponse(response);
        }
    }
}
