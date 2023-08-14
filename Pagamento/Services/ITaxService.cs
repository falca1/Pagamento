using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public interface ITaxService
    {
        
        public double CalculateJurosPagamento(double amount);

        public double CalculateJurosSimples(double amount);
    }
}
