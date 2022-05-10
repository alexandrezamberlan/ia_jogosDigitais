using System;
using System.Collections.Generic;
using System.Linq;

namespace AG_Caxeiro
{
    class Cromossomo
    {
        public string itinerario;
        public int aptidao;
        public Cromossomo(string valor, int[,] mapa, List<char> listaCidades)
        {
            this.itinerario = valor;
            this.calcularAptidao(mapa, listaCidades);
        }


        void calcularAptidao(int[,] mapa, List<char> listaCidades)
        {
            this.aptidao = 0;
            char origem, destino;
            for (int i = 0; i < itinerario.Length - 1; i++)
            {
                origem = this.itinerario[i];
                destino = this.itinerario[i + 1];

                if (mapa[listaCidades.IndexOf(origem), listaCidades.IndexOf(destino)] == 0)
                {
                    this.aptidao = this.aptidao - 5;
                }
            }
        }
    }


    class Program
    {
        static void popularListaCidades(List<char> lista)
        {
            lista.Add('a'); //0
            lista.Add('b'); //1
            lista.Add('c'); //2
            lista.Add('d'); //3
            lista.Add('e'); //4
            lista.Add('f');  //5
            lista.Add('g'); //6

        }

        static void popularMapa(List<char> cidades, int[,] mapa)
        {
            for (int i = 0; i < cidades.Count; i++)
            {
                for (int j = 0; j < cidades.Count; j++)
                {
                    mapa[i, j] = 0;
                }
            }
            mapa[cidades.IndexOf('a'), cidades.IndexOf('b')] = 1;
            mapa[cidades.IndexOf('a'), cidades.IndexOf('e')] = 1;
            mapa[cidades.IndexOf('b'), cidades.IndexOf('c')] = 1;
            mapa[cidades.IndexOf('c'), cidades.IndexOf('d')] = 1;
            mapa[cidades.IndexOf('e'), cidades.IndexOf('b')] = 1;
            mapa[cidades.IndexOf('e'), cidades.IndexOf('f')] = 1;
            mapa[cidades.IndexOf('f'), cidades.IndexOf('g')] = 1;
            mapa[cidades.IndexOf('g'), cidades.IndexOf('b')] = 1;
        }

        static void mostrarMapa(int[,] mapa, List<char> cidades)
        {
            Console.Write("\t");
            for (int i = 0; i < cidades.Count; i++)
            {
                Console.Write(cidades[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < cidades.Count; i++)
            {
                Console.Write(cidades[i] + "\t");
                for (int j = 0; j < cidades.Count; j++)
                {
                    Console.Write(mapa[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        static void embaralharLista<T>(IList<T> lista)
        {
            Random gerador = new Random();
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = gerador.Next(n + 1);
                T value = lista[k];
                lista[k] = lista[n];
                lista[n] = value;
            }
        }

        static void gerarPopulacao(int n, List<char> listaCidades, List<Cromossomo> populacao, int[,] mapa)
        {
            string itinerario = "";
            List<char> listaTmp = new List<char>();

            for (int i = 0; i < n; i++)
            {
                listaTmp.AddRange(listaCidades);
                embaralharLista(listaTmp);
                for (int j = 0; j < listaTmp.Count; j++)
                {
                    itinerario = itinerario + listaTmp[j];
                }

                populacao.Add(new Cromossomo(itinerario,mapa,listaCidades));
                listaTmp.Clear();
                itinerario = "";
            }
        }

        static void mostrarPopulacao(List<Cromossomo> populacao)
        {
            foreach (var i in populacao)
            {
                Console.WriteLine(i.itinerario + " - " + i.aptidao);
            }
        }

        static void ordenar(List<Cromossomo> populacao)
        {
            Cromossomo tmp;
            bool houveTroca;
            do
            {
                houveTroca = false;
                for (int i = 0; i < populacao.Count - 1; i++)
                {
                    if (populacao[i].aptidao < populacao[i+1].aptidao)
                    {
                        houveTroca = true;
                        tmp = populacao[i];
                        populacao[i] = populacao[i + 1];
                        populacao[i + 1] = tmp;
                    }
                }
            } while (houveTroca);
        }

        static void Main(string[] args)
        {
            List<char> cidades = new List<char>();
            popularListaCidades(cidades);
            
            int[,] mapa = new int[cidades.Count, cidades.Count];
            popularMapa(cidades, mapa);

            mostrarMapa(mapa, cidades);

            int qtdIndividuos = 10;
            List<Cromossomo> populacao = new List<Cromossomo>();
            gerarPopulacao(qtdIndividuos, cidades, populacao, mapa);

            ordenar(populacao);
            
            mostrarPopulacao(populacao);
        }
    }
}
