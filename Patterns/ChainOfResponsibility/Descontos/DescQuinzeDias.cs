using Patterns.ChainOfResponsibility.Enums;
using Patterns.ChainOfResponsibility.Interfaces;

namespace Patterns.ChainOfResponsibility.Descontos
{
    public class DescQuinzeDias : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public void CalcularDesconto(OrcamentoCliente orcamento)
        {
            if(orcamento.Quantidade > 15 && orcamento.Quantidade <= 30 && !orcamento.CupomDesconto)
            {
                orcamento.ValorTotal -= (orcamento.ValorTotal * (Convert.ToInt32(ePorcentagem.dois)/ 100));
            }
            else
            {
                this.ProximoDesconto.CalcularDesconto(orcamento);
            }
        }
    }
}
