using MicroservicesRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroservicesRabbitMQ.Banking.Infra.Data.EntitiesConfiguration
{
    public class AccountMap : BaseMap<Account>
    {
        public AccountMap() : base("Accounts")
        {
        }

        public override void Configure(EntityTypeBuilder<Account> builder)
        {
            base.Configure(builder);

            builder.Property(account => account.Balance).HasPrecision(16, 2).IsRequired();
            builder.Property(account => account.AccountType).HasMaxLength(40).IsRequired();
        }
    }
}
