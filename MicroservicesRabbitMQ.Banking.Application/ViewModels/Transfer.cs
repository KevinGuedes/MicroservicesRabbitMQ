namespace MicroservicesRabbitMQ.Banking.Application.ViewModels
{
    public class Transfer
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal Value { get; set; }

    }
}
