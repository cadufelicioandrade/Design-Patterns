using Patterns.FactoryMethod.Interfaces;
using Patterns.FactoryMethod.Servicos;

namespace Patterns.FactoryMethod
{
    public class CalculaServico
    {

        public void CalcularServico(OrcamentoCliente orcamento)
        {
            int tipoServico = 0;

            Console.WriteLine("Selecione o tipo de serviço:\n");
            Console.WriteLine("1 - CoberturaServico");
            Console.WriteLine("2 - MasterServico");
            Console.WriteLine("3 - PremiumServico");
            Console.WriteLine("4 - TradicionalCasalServico");
            Console.WriteLine("5 - TradicionalSolteiroServico\n");

            do
            {
                try
                {
                    Console.WriteLine("Digite no númeo da opções desejada: \n");
                    tipoServico = Convert.ToInt32(Console.ReadLine());
                }
                catch(ArgumentException ex)
                {
                    tipoServico = 6;
                    Console.WriteLine("\nDigite apenas números entre 1 e 5\n");
                }

            } while (!(tipoServico >= 1 && tipoServico <= 5));

            var servico = SelectService(tipoServico);
            servico.Calcular(orcamento);
        }

        private IServicoFactory SelectService(int servico)
        {
            switch (servico)
            {
                case 1: return new CoberturaServico();
                case 2: return new MasterServico();
                case 3: return new PremiumServico();
                case 4: return new TradicionalCasalServico();
                case 5: return new TradicionalSolteiroServico();
                default: return null;

            }
        }

    }
}
