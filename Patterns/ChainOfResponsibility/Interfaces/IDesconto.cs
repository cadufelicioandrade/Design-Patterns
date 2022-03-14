using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Interfaces
{
    public interface IDesconto
    {
        void CalcularDesconto(OrcamentoCliente orcamento);
        IDesconto ProximoDesconto { get; set; }
    }
}
