using Microsoft.Extensions.DependencyInjection;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Context;

namespace MicroservicesRabbitMQ.Transfers.Infra.IoC
{
    public class DependencyResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<TransfersDbContext>();
        }
    }
}
