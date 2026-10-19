using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForms_Domain.Interfaces
{
    public interface InterfaceEvent
    {
        event EventHandler<Exception> eventHandlerException;
        event EventHandler<List<string>> eventHandlerListWithErrors;
        event EventHandler eventhandler; 
    }
}
