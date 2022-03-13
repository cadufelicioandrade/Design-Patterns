using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PorcentagemSobreServico
    {
        public double TradicionalCasal { get; set; }
        public double TradicionaSolteiro { get; set; }
        public double Premium { get; set; }
        public double Master { get; set; }
        public double Cobertura { get; set; }

        public PorcentagemSobreServico(double tradicionalSolteiro = 0,
                                        double  tradicionalCasal = 0,
                                        double premium = 0,
                                        double master = 0,
                                        double  cobertura = 0)
        {
            this.TradicionaSolteiro = tradicionalSolteiro;
            this.TradicionalCasal = tradicionalCasal;
            this.Cobertura = cobertura;
            this.Premium = premium;
            this.Master = master;
        }
    }
}
