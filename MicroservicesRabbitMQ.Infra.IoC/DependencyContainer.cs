using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
