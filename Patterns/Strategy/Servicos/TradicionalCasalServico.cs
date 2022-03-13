using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Servicos
{
    public class TradicionalCasalServico : IServico
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.TradicionalCasal > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.TradicionalCasal);
        }
    }
}
