using MicroRabbit.Domaine.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domaine.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEvantHandler
        where TEvent : Event

    {
        Task Handle(TEvent @event);
    }

    public interface IEvantHandler
    {

    }
}
