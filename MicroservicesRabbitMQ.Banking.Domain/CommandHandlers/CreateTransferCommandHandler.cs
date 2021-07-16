using MediatR;
using MicroservicesRabbitMQ.Banking.Domain.Commands;
using MicroservicesRabbitMQ.Banking.Domain.Events;
using MicroservicesRabbitMQ.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Banking.Domain.CommandHandlers
{
    public sealed class CreateTransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public CreateTransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferCreatedEvent(request.FromAccount, request.ToAccount, request.Value));

            return Task.FromResult(true);
        }
    }
}
