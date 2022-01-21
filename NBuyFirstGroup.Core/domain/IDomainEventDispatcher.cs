using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    public interface IDomainEventDispatcher<TEvent> where TEvent:IDomainEvent
    {
        void Dispatch(TEvent @event);//sevk etmek 
    }
}
