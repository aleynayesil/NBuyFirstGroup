using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    //bu interface event işleyici olarak kullanılır.
    interface IDomainEventHandler<TEvent> where TEvent:IDomainEvent
    {
        void Handle(TEvent @event);
    }
}
