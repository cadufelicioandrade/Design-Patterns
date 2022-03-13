using DesignPatterns.Strategy.Interfaces;
using DesignPatterns.Strategy.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CalculaServico
    {
        public static void Calcular(OrcamentoCliente orcamento)
        {
            List<IServico> servicos = new List<IServico>()
            {
                new CoberturaServico(),
                new MasterServico(),
                new PremiumServico(),
                new TradicionalCasalServico(),
                new TradicionalSolteiroServico()
            };

            foreach (IServico servico in servicos)
            {
                servico.Calcular(orcamento);
            }

        }
    }
}
