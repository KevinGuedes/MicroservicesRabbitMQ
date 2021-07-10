using MicroservicesRabbitMQ.Domain.Core.Events;
using System;

namespace MicroservicesRabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime CreationDate { get; protected set; }

        protected Command()
        {
            CreationDate = DateTime.Now;
        }
    }
}
