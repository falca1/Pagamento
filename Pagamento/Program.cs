using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Pagamento // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Installments:");

            Contract contract = new Contract(number, date, amount);

            ContractService contractService = new ContractService();

            contractService.ProcessContract(contract, months, new TaxBoleto());
           

            foreach (Parcela item in contract.ParcelaList)
            {
                Console.WriteLine(item.DateDue.ToString(CultureInfo.InvariantCulture)+" - "+ item.Amount.ToString("F2",CultureInfo.InvariantCulture));
            }


            
        }
    }
}