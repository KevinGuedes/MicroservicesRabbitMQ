using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Transfers.Domain.Events;
using MicroservicesRabbitMQ.Transfers.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfers.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Transfers.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        private readonly ILogger<TransferEventHandler> _logger;

        public TransferEventHandler(ITransferRepository transferRepository, ILogger<TransferEventHandler> logger)
        {
            _transferRepository = transferRepository;
            _logger = logger;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _logger.LogInformation($"Transfer Created Event Handler accessed. Value transfered: {@event.Value}");

            var transfer = new Transfer(@event.FromAccount, @event.ToAccount, @event.Value);

            _transferRepository.SaveTransfer(transfer);

            return Task.CompletedTask;
        }
    }
}
