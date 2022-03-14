namespace Patterns
{
    public class OrcamentoCliente
    {
        public double ValorDiaria { get; set; }
        public int  Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public bool CupomDesconto { get; set; }
        public PorcentagemSobreServico Porcentagem { get; set; }


        public OrcamentoCliente(double valorDiaria,
                        int quantidade,
                        PorcentagemSobreServico porcentagem,
                        bool cupomDesconto)
        {
            this.ValorDiaria = valorDiaria;
            this.Quantidade = quantidade;
            this.Porcentagem = porcentagem;
            this.CupomDesconto = cupomDesconto;
        }

    }
}
