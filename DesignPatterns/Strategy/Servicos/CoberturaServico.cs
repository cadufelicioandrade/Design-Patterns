using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Servicos
{
    public class CoberturaServico : IServico
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.Cobertura > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.Cobertura);
        }
    }
}
