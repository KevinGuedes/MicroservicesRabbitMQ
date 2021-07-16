using MicroservicesRabbitMQ.Domain.Core.Entities;

namespace MicroservicesRabbitMQ.Transfers.Domain.Models
{
    public class Transfer : Base
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal Value { get; set; }
    }
}
