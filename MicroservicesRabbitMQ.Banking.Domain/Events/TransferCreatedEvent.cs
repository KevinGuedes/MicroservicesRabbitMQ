using MicroservicesRabbitMQ.Domain.Core.Events;

namespace MicroservicesRabbitMQ.Banking.Domain.Events
{
    public sealed class TransferCreatedEvent : Event
    {
        public int FromAccount { get; private set; }

        public int ToAccount { get; private set; }

        public decimal Value { get; private set; }

        public TransferCreatedEvent(int fromAccount, int toAccount, decimal value)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Value = value;
        }
    }
}
