using MicroservicesRabbitMQ.Domain.Core.Commands;
using MicroservicesRabbitMQ.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<TEvent>(TEvent @event) where TEvent : Event;

        void Subscribe<TEvent, THandler>() where TEvent : Event where THandler : IEventHandler<TEvent>;
    }
}
