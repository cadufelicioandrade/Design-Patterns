using Patterns.FactoryMethod.Interfaces;

namespace Patterns.FactoryMethod.Servicos
{
    public class MasterServico : IServicoFactory
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.Master > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.Master);
        }
    }
}
