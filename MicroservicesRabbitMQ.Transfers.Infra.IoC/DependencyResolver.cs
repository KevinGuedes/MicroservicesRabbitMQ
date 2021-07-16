using Microsoft.Extensions.DependencyInjection;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Context;
using MediatR;
using System;

namespace MicroservicesRabbitMQ.Transfers.Infra.IoC
{
    public class DependencyResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.Load("MicroservicesRabbitMQ.Transfers.Application"));

            services.AddTransient<TransfersDbContext>();
        }
    }
}
