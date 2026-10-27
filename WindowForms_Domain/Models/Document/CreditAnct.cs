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
                
            }

        }
    }
}
