using System;
using System.Collections.Generic;
using WindowForms_Domain.Models.Credit.CreditClassDocument;

namespace WindowForms_Domain.Models.Document
{
    public class CreditAnct
    {
        /// <summary>
        /// Заявление-анкета на получение кредита .
        /// </summary>
        public class CreditApplication
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
                    this.eventHandlerListWithErrors.Invoke(this, listError);
                }
                if (listWarning.Count > 0)
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
