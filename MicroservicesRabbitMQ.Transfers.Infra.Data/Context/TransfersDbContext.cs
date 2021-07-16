using MicroservicesRabbitMQ.Transfers.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesRabbitMQ.Transfers.Infra.Data.Context
{
    public class TransfersDbContext : DbContext
    {
        public TransfersDbContext(DbContextOptions<TransfersDbContext> options) : base(options)
        {
        }

        public DbSet<Transfer> Transfers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
