using Patterns.FactoryMethod.Interfaces;

namespace Patterns.FactoryMethod.Servicos
{
    public class CoberturaServico : IServicoFactory
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.Cobertura > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.Cobertura);
        }
    }
}
