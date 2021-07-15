using MicroservicesRabbitMQ.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMQ.Transfers.Domain.Models
{
    public class Transfer : Base
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal Value { get; set; }
    }
}
