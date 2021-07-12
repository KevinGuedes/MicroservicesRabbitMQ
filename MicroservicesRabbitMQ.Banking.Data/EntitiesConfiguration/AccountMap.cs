﻿using MicroservicesRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroservicesRabbitMQ.Banking.Data.EntitiesConfiguration
{
    public class AccountMap : BaseMap<Account>
    {
        public AccountMap() : base("Account")
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