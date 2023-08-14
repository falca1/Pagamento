



namespace Pagamento
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

         public List<Parcela> ParcelaList { get; set; }

       

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            ParcelaList = new List<Parcela>();
            
        }

        


        
        



    }
}
