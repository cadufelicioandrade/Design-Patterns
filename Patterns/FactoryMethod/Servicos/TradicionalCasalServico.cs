using Patterns.FactoryMethod.Interfaces;

namespace Patterns.FactoryMethod.Servicos
{
    public class TradicionalCasalServico : IServicoFactory
    {
        public void Calcular(OrcamentoCliente orcamento)
        {
            if (orcamento.Porcentagem.TradicionalCasal > 0)
                orcamento.ValorTotal += (orcamento.ValorTotal * orcamento.Porcentagem.TradicionalCasal);
        }
    }
}
