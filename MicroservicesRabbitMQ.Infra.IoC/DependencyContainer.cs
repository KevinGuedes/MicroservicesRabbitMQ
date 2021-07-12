using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.Services;
using MicroservicesRabbitMQ.Banking.Data.Context;
using MicroservicesRabbitMQ.Banking.Data.Repositories;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;

namespace MicroservicesRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domai Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
