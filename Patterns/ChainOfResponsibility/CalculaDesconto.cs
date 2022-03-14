using Patterns.ChainOfResponsibility.Descontos;
using Patterns.ChainOfResponsibility.Interfaces;

namespace Patterns.ChainOfResponsibility
{
    public class CalculaDesconto
    {
        public static void Calcular(OrcamentoCliente orcamento)
        {
            IDesconto d1 = new DescQuinzeDias();
            IDesconto d2 = new DescTrintaDias();
            IDesconto d3 = new DescCupom();
            IDesconto d4 = new SemDesconto();

            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;
            d3.ProximoDesconto = d4;

            d1.CalcularDesconto(orcamento);
        }
    }
}
