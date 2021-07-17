using MicroservicesRabbitMQ.Transfers.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Transfers.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<Transfer> GetTransfers();
    }
}
