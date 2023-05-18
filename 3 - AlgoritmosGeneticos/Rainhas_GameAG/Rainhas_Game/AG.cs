using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainhas_Game
{
    internal class AG
    {
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

        public static void ordenarPopulacao(List<Matriz> populacao)
        {
            List<Matriz> populacaoOrdenada = populacao.OrderBy(x => x.qtdRestricoesFalhas).ToList();            
            populacao.Clear();
            populacao.AddRange(populacaoOrdenada);
        }

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

        public static void selecionarPopulacaoPorTorneio(List<Matriz> populacao, List<Matriz> novaPopulacao, int taxaSelecao)
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
            int posicao;
            do
            {
                c1 = populacao[gerador.Next(populacao.Count)];

                do
                {
                    posicao = gerador.Next(populacao.Count);
                    c2 = populacao[posicao];
                    //Console.WriteLine("preso na escolha do c2 " + posicao);
                    
                } while (AG.saoIguais(c1, c2));

                do
                {
                    posicao = gerador.Next(populacao.Count);
                    c3 = populacao[posicao];
                    //Console.WriteLine("preso na escolha do c3 " + posicao);
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
            } while (i < qtdSelecionados-1);

            //podar a novaPopulacao, retirando os excedentes do final
            while (novaPopulacao.Count() > populacao.Count())
            {
                novaPopulacao.RemoveAt(novaPopulacao.Count() - 1);
            }
        }

        public static void reproduzirPopulacao(List<Matriz> populacao, List<Matriz> novaPopulacao, int taxaReproducao)
        {
            //100             -  populacao.count
            //taxaReproducao  - qtdReproduzidos == qtdGeradosNovos
            int qtdReproduzidos = (taxaReproducao * populacao.Count) / 100;

            Matriz pai, filho1, filho2;
            Matriz mae;

            int[,] mPai, mMae, mFilho1, mFilho2;
            
            Random gerador = new Random();

            int i = 0;
            do
            {
                pai = populacao[gerador.Next((int)populacao.Count / 3)];

                do
                {
                    mae = populacao[gerador.Next(populacao.Count)];
                } while (AG.saoIguais(pai, mae));

                //pai.exibirMatriz("exibindo o pai");
                //mae.exibirMatriz("exibindo a mae");

                mFilho1 = new int[pai.dimensaoMatriz, pai.dimensaoMatriz];
                mFilho2 = new int[pai.dimensaoMatriz, pai.dimensaoMatriz];

                mPai = pai.matriz;
                mMae = mae.matriz;

                int metade = (int)pai.dimensaoMatriz / 2;

                for (int lin = 0; lin < metade; lin++)
                {
                    for (int col = 0; col < pai.dimensaoMatriz; col++)
                    {
                        mFilho1[lin, col] = mPai[lin,col];
                    }
                }
                for (int lin = metade; lin < pai.dimensaoMatriz; lin++)
                {
                    for (int col = 0; col < pai.dimensaoMatriz; col++)
                    {
                        mFilho1[lin, col] = mMae[lin, col];
                    }
                }
                for (int lin = 0; lin < metade; lin++)
                {
                    for (int col = 0; col < pai.dimensaoMatriz; col++)
                    {
                        mFilho2[lin, col] = mMae[lin, col];
                    }
                }
                for (int lin = metade; lin < pai.dimensaoMatriz; lin++)
                {
                    for (int col = 0; col < pai.dimensaoMatriz; col++)
                    {
                        mFilho2[lin, col] = mPai[lin, col];
                    }
                }

                filho1 = new Matriz(mFilho1);
                filho2 = new Matriz(mFilho2);
                novaPopulacao.Add(filho1);
                novaPopulacao.Add(filho2);

                if (filho1.ehMeta())
                {
                    filho1.exibirMatriz("FILHO 1 EH META");                    
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (filho2.ehMeta())
                {
                    filho2.exibirMatriz("FILHO 2 EH META");
                    Console.ReadKey();
                    Environment.Exit(0);
                }


                i = i + 2;
            } while (i < qtdReproduzidos);

            //podar o final que sobra da novaPopulacao
            while (populacao.Count < novaPopulacao.Count)
            {
                //podar o fim da novaPopulacao
                novaPopulacao.RemoveAt(novaPopulacao.Count - 1);
            }

        }

        public static void clonar (int[,] origem, int[,] destino)
        {
            for (int lin = 0; lin < origem.GetLength(0); lin++)
            {
                for (int col = 0; col < origem.GetLength(0); col++)
                {
                    destino[lin, col] = origem[lin, col];
                }
            }

        }

        public static void mutarPopulacao(List<Matriz> populacao)
        {
            Random gerador = new Random();
            int qtdMutantes = gerador.Next(populacao.Count / 5) + 1;
            Matriz mutante;
            int posicaoMutante;
            int linSorteada;
            int colSorteada;

            int[,] matrizTemporaria;

            for (; qtdMutantes > 0; qtdMutantes--)
            {
                posicaoMutante = gerador.Next(populacao.Count);
                mutante = populacao[posicaoMutante];
                matrizTemporaria = new int[mutante.dimensaoMatriz, mutante.dimensaoMatriz];

                clonar(mutante.matriz, matrizTemporaria);

                linSorteada = gerador.Next(mutante.dimensaoMatriz);
                colSorteada = gerador.Next(mutante.dimensaoMatriz);

                if (matrizTemporaria[linSorteada, colSorteada] == 1)
                {
                    matrizTemporaria[linSorteada, colSorteada] = 0;
                } else
                {
                    matrizTemporaria[linSorteada, colSorteada] = 1;
                }
                                
                mutante = new Matriz(matrizTemporaria);

                //recalculando sua aptidao
                populacao[posicaoMutante] = mutante;

                if (mutante.ehMeta())
                {
                    mutante.exibirMatriz("DEUUUUUUU");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

    }
}
