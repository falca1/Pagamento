
namespace Pagamento
{
    public class Parcela
    {
        public DateTime DateDue { get; set; }
        public double Amount { get; set; }

        public Parcela(DateTime dateDue, double amount)
        {
            DateDue = dateDue;
            Amount = amount;
        }
    }
}
