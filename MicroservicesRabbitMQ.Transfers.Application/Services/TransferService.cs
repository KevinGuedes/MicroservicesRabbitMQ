using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Transfers.Application.Interfaces;
using MicroservicesRabbitMQ.Transfers.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfers.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Transfers.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Transfer> GetTransfers()
        {
            return _transferRepository.GetTransfers();
        }
    }
}
