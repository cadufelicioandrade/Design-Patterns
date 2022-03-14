using Patterns.ChainOfResponsibility.Enums;
using Patterns.ChainOfResponsibility.Interfaces;

namespace Patterns.ChainOfResponsibility.Descontos
{
    public class DescTrintaDias : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public void CalcularDesconto(OrcamentoCliente orcamento)
        {
            if(orcamento.Quantidade > 30 && !orcamento.CupomDesconto)
            {
                orcamento.ValorTotal -= (orcamento.ValorTotal * (Convert.ToInt32(ePorcentagem.tres) / 100));
            }
            else
            {
                this.ProximoDesconto.CalcularDesconto(orcamento);
            }
        }
    }
}
