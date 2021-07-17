using MediatR;
using MicroservicesRabbitMQ.Transfers.Application.Interfaces;
using MicroservicesRabbitMQ.Transfers.Application.Services;
using MicroservicesRabbitMQ.Transfers.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Context;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroservicesRabbitMQ.Transfers.Infra.IoC
{
    public class DependencyResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.Load("MicroservicesRabbitMQ.Transfers.Application"));

            services.AddTransient<ITransferService, TransferService>();

            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransfersDbContext>();
        }
    }
}
