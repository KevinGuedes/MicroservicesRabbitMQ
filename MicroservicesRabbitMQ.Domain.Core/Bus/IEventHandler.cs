using MicroservicesRabbitMQ.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
