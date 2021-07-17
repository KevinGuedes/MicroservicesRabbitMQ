using MicroservicesRabbitMQ.Domain.Core.Bus;
using MicroservicesRabbitMQ.Transfers.Domain.Events;
using MicroservicesRabbitMQ.Transfers.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Transfers.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
        }

        //public TransferEventHandler(ITransferRepository transferRepository)
        //{
        //    _transferRepository = transferRepository;
        //}

        public Task Handle(TransferCreatedEvent @event)
        {
            //var transfer = new Transfer(@event.FromAccount, @event.ToAccount, @event.Value);

            //_transferRepository.SaveTransfer(transfer);

            return Task.CompletedTask;
        }
    }
}
