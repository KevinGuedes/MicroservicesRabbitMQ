using MicroservicesRabbitMQ.Transfers.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroservicesRabbitMQ.Transfers.Infra.Data.EntitiesConfiguration
{
    public class TransferMap : BaseMap<Transfer>
    {
        public TransferMap() : base("Transfers")
        {
        }

        public override void Configure(EntityTypeBuilder<Transfer> builder)
        {
            base.Configure(builder);

            builder.Property(transfer => transfer.FromAccount).IsRequired();
            builder.Property(transfer => transfer.ToAccount).IsRequired();
            builder.Property(transfer => transfer.Value).HasPrecision(16,2).IsRequired();
        }
    }
}
