using MicroservicesRabbitMQ.Domain.Core.Commands;

namespace MicroservicesRabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferCommand : Command
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal Value { get; set; }

        public CreateTransferCommand(int fromAccount, int toAccount, decimal value)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Value = value;
        }
    }
}
