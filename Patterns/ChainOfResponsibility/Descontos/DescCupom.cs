using Patterns.ChainOfResponsibility.Enums;
using Patterns.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Descontos
{
    public class DescCupom : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public void CalcularDesconto(OrcamentoCliente orcamento)
        {
            if (orcamento.CupomDesconto)
            {
                orcamento.ValorTotal -= (orcamento.ValorTotal * (Convert.ToInt32(ePorcentagem.cinco) / 100));
            }
            else
            {
                this.ProximoDesconto.CalcularDesconto(orcamento);
            }

        }
    }
}
