using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowForms_Domain.Models;
using WindowForms_Domain.Models.Client;
using WinFormss.Domain.Models;

namespace WindowForms_Domain.Interfaces
{
    /// <summary>
    /// Интерфейс управляющий составлении отчетом 
    /// </summary>
    public interface IReportToolsManagment
    {
        /// <summary>
        /// Метод создающий документ итоговой
        /// </summary>
        /// <param name="credit"></param>
        /// <param name="client"></param>
        void CreateReport(CreditForDocument credit, Client client);
        /// <summary>
        /// Метод для удаления анкеты
        /// </summary>
        /// <param name="anct"></param>
        void DeleteReport(CreditAnct anct);
    }
}
