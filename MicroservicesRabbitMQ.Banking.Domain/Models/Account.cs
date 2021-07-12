namespace MicroservicesRabbitMQ.Banking.Domain.Models
{
    public class Account : Base
    {
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
