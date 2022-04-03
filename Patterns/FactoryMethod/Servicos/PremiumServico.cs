using Patterns.FactoryMethod.Interfaces;

namespace Patterns.FactoryMethod.Servicos
{
    public class PremiumServico : IServicoFactory
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.Premium > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.Premium);
        }
    }
}
