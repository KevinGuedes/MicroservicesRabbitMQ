using MediatR;
using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.Services;
using MicroservicesRabbitMQ.Banking.Domain.CommandHandlers;
using MicroservicesRabbitMQ.Banking.Domain.Commands;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Banking.Infra.Data.Context;
using MicroservicesRabbitMQ.Banking.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroservicesRabbitMQ.Banking.Infra.IoC
{
    public class DependencyResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.Load("MicroservicesRabbitMQ.Banking.Application"));

            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, CreateTransferCommandHandler>();

            services.AddTransient<IAccountService, AccountService>();

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
