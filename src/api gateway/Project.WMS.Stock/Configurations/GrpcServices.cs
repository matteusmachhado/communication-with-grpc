﻿using Project.WMS.Stock.Services.gRPC;
using Project.WMS.WebAPI.Core.Configurations;

namespace Project.WMS.Stock.Configurations
{
    public static class GrpcServices
    {
        public static void ConfigureGrpcServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductGrpcService, ProductGrpcService>();

            services.AddGrpcClient<Product.WebAPI.Services.gRPC.Product.ProductClient>(opt =>
            {
                opt.Address = new Uri(configuration["Project.WMS.Product.WebAPI:Url"]);
            })
            .ConfigurePrimaryHttpMessageHandler(ApiConfig.AllowSelfSignedCertificate);
        }
    }
}
