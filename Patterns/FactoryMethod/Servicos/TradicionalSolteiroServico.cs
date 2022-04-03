using Patterns.FactoryMethod.Interfaces;

namespace Patterns.FactoryMethod.Servicos
{
    public class TradicionalSolteiroServico : IServicoFactory
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.TradicionaSolteiro > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.TradicionaSolteiro);
        }
    }
}
