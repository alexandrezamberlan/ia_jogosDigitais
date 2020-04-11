using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG
{
    class Cromossomo
    {
        public string valor;
        public int aptidao;
        public int aptidaoPorcentagem;

        public Cromossomo(string valor, string palavraFinal)
        {
            this.valor = valor;
            this.aptidao = calcularAptidao(palavraFinal);
            this.aptidaoPorcentagem = 0;
        }

        public int calcularAptidao(string palavraFinal)
        {
            int nota = 0;
            for (int i = 0; i < palavraFinal.Count(); i++)
            {
                if (this.valor.Contains(palavraFinal.ElementAt(i) + ""))
                {
                    nota += 5;
                }
                if (this.valor.ElementAt(i) == palavraFinal.ElementAt(i))
                {
                    nota += 50;
                }
            }
            return nota;
        }
    }
}
