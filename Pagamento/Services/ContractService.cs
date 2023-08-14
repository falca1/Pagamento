
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public class ContractService
    {
        public double tax { get; set; }
        public double finalValue { get; set; }
        public void ProcessContract(Contract contract, int months, ITaxService taxService)
        {
            double basicParcela = contract.TotalValue / months;
            tax = 0;
            finalValue = 0;
            for (int i = 1; i <= months; i++)
            {
                tax = basicParcela + (taxService.CalculateJurosSimples(basicParcela) * i);

                finalValue = tax + taxService.CalculateJurosPagamento(tax);

                contract.ParcelaList.Add(new Parcela(contract.Date.AddMonths(i), finalValue));
            }


        }



    }
}
