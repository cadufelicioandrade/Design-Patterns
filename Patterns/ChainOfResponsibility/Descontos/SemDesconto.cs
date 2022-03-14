using Patterns.ChainOfResponsibility.Interfaces;

namespace Patterns.ChainOfResponsibility.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public void CalcularDesconto(OrcamentoCliente orcamento)
        {
            orcamento.ValorTotal -= 0;
        }
    }
}
