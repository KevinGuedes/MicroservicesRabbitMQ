using MediatR;
using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Infra.IoC;
using MicroservicesRabbitMQ.Transfers.Domain.EventHandlers;
using MicroservicesRabbitMQ.Transfers.Domain.Events;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Context;
using MicroservicesRabbitMQ.Transfers.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MicroservicesRabbitMQ.Transfers.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            AddConfigurations(services);

            services.AddDbContext<TransfersDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("TransfersDbConnection"));
            }
            );

            services.AddControllers();

            //services.AddMediatR(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MicroservicesRabbitMQ.Transfers.Api", Version = "v1" });
            });
        }

        private static void AddConfigurations(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
            DependencyResolver.RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transfers Microservice v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureEventBus(app);
        }

        private static void ConfigureEventBus(IApplicationBuilder app)
        {
            var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
            eventBus.Subscribe<TransferCreatedEvent, TransferEventHandler>();
        }
    }
}
