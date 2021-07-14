using System;

namespace MicroservicesRabbitMQ.Domain.Core.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
