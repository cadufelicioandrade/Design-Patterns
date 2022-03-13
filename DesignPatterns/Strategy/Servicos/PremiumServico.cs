using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Servicos
{
    public class PremiumServico : IServico
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.Premium > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.Premium);
        }
    }
}
