using MicroservicesRabbitMQ.Domain.Core.Entities;
using System;

namespace MicroservicesRabbitMQ.Transfers.Domain.Models
{
    public class Transfer : Base
    {
        public int FromAccount { get; private set; }

        public int ToAccount { get; private set; }

        public decimal Value { get; private set; }

        public Transfer(int fromAccount, int toAccount, decimal value)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Value = value;
            CreationDate = DateTime.Now;
        }
    }
}
