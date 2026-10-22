namespace WindowForms_Domain.Models.Paymentt
{
    public class Payment
    {
        public int Month { get; set; }              // номер месяца (1..N)
        public decimal BalanceBefore { get; set; }  // остаток долга до платежа
        public decimal Principal { get; set; }      // погашение основного долга
        public decimal Interest { get; set; }       // проценты за месяц

        //  сколько денег ушло в этом месяце
        public virtual decimal Total => Principal + Interest;

        // Остаток долга после платежа 
        public decimal BalanceAfter => BalanceBefore - Principal;
    }
}
