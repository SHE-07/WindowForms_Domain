using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowForms_Domain.Models.Paymentt;

namespace WindowForms_Domain.Models.Credit.TypeCreditClass
{
    public class AnnuityCredit : Creditt
    {
        public decimal MonthlyPayment { get; private set; }

        public override IEnumerable<Payment> GetSchedule()
        {
            decimal m = MonthlyRate;
            // K = M*(1+M)^N / ((1+M)^N - 1)
            double pow = Math.Pow(1 + (double)m, Months);
            decimal k = (decimal)((double)m * pow / (pow - 1));
            MonthlyPayment = Math.Round(Amount * k, 2);

            decimal balance = Amount;
            for (int month = 1; month <= Months; month++)
            {
                decimal interest = Math.Round(balance * m, 2);
                decimal principal = MonthlyPayment - interest;

                // последний месяц корректируем, чтобы закрыть остаток ровно
                if (month == Months) principal = balance;

                yield return new Payment
                {
                    Month = month,
                    BalanceBefore = balance,
                    Principal = principal,
                    Interest = interest
                };
                balance -= principal;
            }
        }
    }
}
