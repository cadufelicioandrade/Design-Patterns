using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface IServico
    {
        void Calcular(OrcamentoCliente orcamento);
    }
}
