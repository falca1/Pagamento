using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public class TaxPayPal : ITaxService
    {
        const double TAXAJUROSSIMPLES = 0.01;
        const double TAXAPAYPAL = 0.02;

        public double CalculateJurosPagamento(double amount)
        {
            double tax = amount * TAXAPAYPAL;
            return tax;
        }

        public double CalculateJurosSimples(double amount)
        {
            double tax = amount * TAXAJUROSSIMPLES;
            return tax;
        }
    }
}
