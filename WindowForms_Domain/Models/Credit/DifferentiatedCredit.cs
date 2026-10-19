using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowForms_Domain.Models.Paymentt;

namespace WindowForms_Domain.Models.Credit
{
    public class DifferentiatedCredit : Creditt
    {
        public override IEnumerable<Payment> GetSchedule()
        {
            decimal m = MonthlyRate;
            decimal principalPart = Math.Round(Amount / Months, 2);
            decimal balance = Amount;

            for (int month = 1; month <= Months; month++)
            {
                decimal interest = Math.Round(balance * m, 2);
                decimal principal = (month == Months) ? balance : principalPart;

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
