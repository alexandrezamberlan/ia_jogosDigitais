using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronChuva
{
    public class Clima
    {
        public int limiar; //1 - chove; -1 - nao chove

        public int presencaNuvens; //0 a 5 -> 0 sem nuvens, 5 muitas nuvens
        public int sensacaoTermica; //0 a 5 -> 0 frio, 5 quente
        public int estacaoAno; //1, 2, 3, 4 -> 1 outono, 2 - inverno, 3 - primavera, 4 - verao

        public Clima(int presencaNuvens, int sensacaoTermica, int estacaoAno)
        {
            this.presencaNuvens = presencaNuvens;
            this.sensacaoTermica = sensacaoTermica;
            this.estacaoAno = estacaoAno;
        }
    }
}
