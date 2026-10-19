using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowForms_Domain.Interfaces;
using WindowForms_Domain.Models.Client;
using WindowForms_Domain.Models.Credit;
using WinFormss.Domain.Models;

namespace WindowForms_Domain.Models
{
    public class CreditAnct
    {
        /// <summary>
        /// Заявление-анкета на получение кредита .
        /// </summary>
        public class CreditApplication : InterfaceEvent
        {
            /// <summary>
            /// Обьект Client 
            /// </summary>
            public Client.Client ClientInfo { get; set; } = new Client.Client();
            /// <summary>
            /// Обьект Credit  
            /// </summary>
            public CreditForDocument credit { get; set; } = new CreditForDocument();
            public CreditApplication(Client.Client clientInfo, CreditForDocument credit)
            {
                this.ClientInfo = clientInfo;
                this.credit = credit;
                var listError = this.ClientInfo.Validate();
                var listWarning = this.credit.Validate();
                if (listError.Count > 0)
                {
                    this.eventHandlerListWithErrors.Invoke(this,listError);
                }
                if(listWarning.Count > 0)
                {
                    this.eventHandlerListWithErrors.Invoke(this, listWarning);
                }

            }

            /// <summary>
            /// событие с Exception
            /// </summary>
            public event EventHandler<Exception> eventHandlerException;
            /// <summary>
            /// событие с List<string>
            /// </summary>
            public event EventHandler<List<string>> eventHandlerListWithErrors;
            /// <summary>
            /// Событие EventHandler
            /// </summary>
            public event EventHandler eventhandler;
        }
    }
}
