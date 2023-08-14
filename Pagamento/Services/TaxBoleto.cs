using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public class TaxBoleto : ITaxService
    {

        const double TAXAJUROSSIMPLES = 0.01;
        

        public double CalculateJurosPagamento(double amount)
        {
            return 0;
        }

        public double CalculateJurosSimples(double amount)
        {
            double tax = amount * TAXAJUROSSIMPLES;
            return tax;
        }

        
    }
}
