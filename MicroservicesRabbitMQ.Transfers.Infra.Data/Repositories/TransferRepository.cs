using MicroservicesRabbitMQ.Transfers.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfers.Domain.Models;
using MicroservicesRabbitMQ.Transfers.Infra.Data.Context;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Transfers.Infra.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransfersDbContext _transfersDbContext;


        public TransferRepository(TransfersDbContext transfersDbContext)
        {
            _transfersDbContext = transfersDbContext;
        }

        public IEnumerable<Transfer> GetTransfers()
        {
            return _transfersDbContext.Transfers;
        }
    }
}
