using MicroservicesRabbitMQ.Transfers.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Transfers.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<Transfer> GetTransfers();
    }
}
