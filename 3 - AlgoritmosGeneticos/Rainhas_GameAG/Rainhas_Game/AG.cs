using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainhas_Game
{
    internal class AG
    {
        //incializarPopulacao
        public static void inicializarPopulacao(List<Matriz> populacao, int tamanhoPopulacao, int tamanhoMatriz)
        {
            for (int i = 0; i < tamanhoPopulacao; i++)
            {
                populacao.Add(new Matriz(tamanhoMatriz));
                populacao[i].preencherMatriz();
                populacao[i].verificarRestricoes();                
                if (populacao[i].ehMeta())
                {
                    Console.WriteLine("Achou!!!!!");
                    break;
                }
            }
        }

        //ordenarPopulacao
        public static void ordenarPopulacao(List<Matriz> populacao)
        {
            List<Matriz> populacaoOrdenada = populacao.OrderBy(x => x.qtdRestricoesFalhas).ToList();            
            populacao.Clear();
            populacao.AddRange(populacaoOrdenada);
        }

        //exibirPopulacao
        public static void exibirPopulacao(List<Matriz> populacao, string frase)
        {
            Console.WriteLine(frase);
            for (int i = 0; i < populacao.Count; i++)
            {
                populacao[i].exibirMatriz("Tabuleiro...." + i);
            }
        }


        public static bool saoIguais(Matriz individuo1, Matriz individuo2)
        {
            for (int i = 0; i < individuo1.dimensaoMatriz; i++)
            {
                for (int j = 0; j < individuo1.dimensaoMatriz; j++)
                {
                    if (individuo1.matriz[i,j] != individuo2.matriz[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool contem(List<Matriz> populacao, Matriz selecionada)
        {
            for (int i = 0; i < populacao.Count; i++)
            {
                if (AG.saoIguais(populacao[i], selecionada))
                {
                    return true;
                }
            }
            return false;
        }

        public static void selecionarPopulacaoPorTorneio(List<Matriz> populacao,
                                     List<Matriz> novaPopulacao, int taxaSelecao)
        {
            //100          -  populacao.count
            //taxaSelecao  - qtdSelecionados
            int qtdSelecionados = (taxaSelecao * populacao.Count) / 100;
            // Console.WriteLine("Quantidade de selecionados: " + qtdSelecionados);

            Matriz c1, c2, c3;
            Random gerador = new Random();
            List<Matriz> torneio = new List<Matriz>();
            Matriz selecionada;

            int i = 0;
            do
            {
                c1 = populacao[gerador.Next(populacao.Count)];

                do
                {
                    c2 = populacao[gerador.Next(populacao.Count)];
                } while (AG.saoIguais(c1, c2));

                do
                {
                    c3 = populacao[gerador.Next(populacao.Count)];
                } while (AG.saoIguais(c3, c1) || AG.saoIguais(c3, c2));

                torneio.Add(c1);
                torneio.Add(c2);
                torneio.Add(c3);

                ordenarPopulacao(torneio); //ordena de forma decrescente do mais apto ao menos apto
                selecionada = torneio[0];

                if (!AG.contem(novaPopulacao, selecionada))
                {
                    novaPopulacao.Add(selecionada);
                    i++;
                    //Console.WriteLine("selecionado.... " + selecionado.valor);
                }
                torneio.Clear();
            } while (i < qtdSelecionados);
        }
    }
}
