using System.Collections.Generic;
using System.Linq;
using WindowForms_Domain.Models.Paymentt;

namespace WindowForms_Domain.Models.Credit
{
    public abstract class Creditt
    {
        public decimal Amount { get; set; }         // S
        public decimal AnnualRate { get; set; }     // годовая ставка (0.12)
        public int Months { get; set; }             // N

        protected decimal MonthlyRate => AnnualRate / 12; // M

        // Каждая схема возвращает свой график платежей
        public abstract IEnumerable<Payment> GetSchedule();

        // Общие вычисления, не зависящие от схемы
        public decimal TotalPaid => GetSchedule().Sum(p => p.Total);
        public decimal TotalInterest => GetSchedule().Sum(p => p.Interest);
        public decimal Overpayment => TotalPaid - Amount;
    }
}
