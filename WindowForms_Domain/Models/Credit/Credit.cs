using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowForms_Domain.Models.Payment;

namespace WindowForms_Domain.Models.Credit
{
    public abstract class Creditt
    {
        public decimal Amount { get; set; }         // S
        public decimal AnnualRate { get; set; }     // годовая ставка, в долях (0.12)
        public int Months { get; set; }             // N

        protected decimal MonthlyRate => AnnualRate / 12m; // M

        // Каждая схема возвращает свой график платежей
        public abstract IEnumerable<Paymentt> GetSchedule();

        // Общие вычисления, не зависящие от схемы
        public decimal TotalPaid => GetSchedule().Sum(p => p.Total);
        public decimal TotalInterest => GetSchedule().Sum(p => p.Interest);
        public decimal Overpayment => TotalPaid - Amount;
    }
}
