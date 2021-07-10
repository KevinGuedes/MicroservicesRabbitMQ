using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime CreationDate { get; protected set; }

        protected Event()
        {
            CreationDate = DateTime.Now;
        }
    }
}
