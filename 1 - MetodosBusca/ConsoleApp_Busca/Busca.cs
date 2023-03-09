using System;
using System.Collections;

namespace ConsoleApp_Busca
{
    public class Busca
    {
        /// <summary>
        /// vetor de visitados que controla os nodos ou vertice que sao ou nao visitados durante a busca
        /// </summary>
        static int[] visitados;
        /// <summary>
        /// estrutura de dados usada no metodo de busca por amplitude
        /// </summary>
        static Queue<int> fila;

        
        /// <summary>
        /// metodo recursivo que recebe um no vigente, um no destino, um grafo e a lista de cidades para a impressao do nome da cidade
        /// </summary>
        /// <param name="no">vertice atual em que o metodo esta realizando a busca</param>
        /// <param name="destino">vertice objetivo da busca</param>
        /// <param name="grafo">matriz representando o mapa das cidades com suas distancias</param>
        /// <param name="cidades">lista das cidades com seus respectivos nomes</param>
        /// <returns>um valor inteiro representando se conseguiu ou nao um caminho - 1 significa que sim, 0 que nao</returns>
        static void buscaProfundidade(int no, int destino, Grafo grafo, List<string> cidades)
        {
            int i;
            //usar o vértice no - printf, if, cont
            System.Console.Write(cidades[no] + "\t");

            if (no == destino)
            {
                Console.WriteLine("CHEGUEIIIIIIIIIII");
                return ; //localizei um caminho
            }

            for (i = 0; i < grafo.QuantidadeVertices; i++)
            {
                if (grafo.MatrizAdjacencia[no, i] != 0 && visitados[i] == 0)
                {
                    visitados[i] = 1;
                    buscaProfundidade(i, destino, grafo, cidades); //chamada recursiva, ou seja é aqui que o nodo visitado é inserido na pilha
                }
            }
            Console.Write("por aqui, nao tem caminho.....preciso voltar...");
        }

        /// <summary>
        /// metodo de busca por forca bruta do tipo profundidade
        /// </summary>
        /// <param name="origem">vertice de partida no mapa</param>
        /// <param name="destino">vertice objetivo no mapa</param>
        /// <param name="grafo">matriz que representa um mapa</param>
        /// <param name="cidades">lista das cidades com seus respectivos nomes</param>
        public static void mostraCaminhoProfundidade(int origem, int destino, Grafo grafo, List<string> cidades)
        {
            //aloco e inicializo vetor de visitados
            visitados = new int[grafo.QuantidadeVertices];
            for (int i = 0; i < grafo.QuantidadeVertices; i++)
            {
                visitados[i] = 0;  //setando que cada nodo do grafo fique no status nao visitado
            }
            visitados[origem] = 1;

            buscaProfundidade(origem, destino, grafo, cidades); //chama a pilha recursiva do SO
        }



        public static void mostraCaminhoAmplitude(int origem, int destino, Grafo grafo, List<string> cidades)
        {
            //aloco e inicializo vetor de visitados
            visitados = new int[grafo.QuantidadeVertices];
            for (int i = 0; i < grafo.QuantidadeVertices; i++)
            {
                visitados[i] = 0;
            }
            //inicializo a fila
            fila = new Queue<int>();
            visitados[origem] = 1;
            int no = origem;
            do
            {
                //usar o vertice - print, if, cont, ...            
                System.Console.Write(cidades[no] + "\t");
                if (no == destino) return;

                for (int i = 0; i < grafo.QuantidadeVertices; i++)
                {
                    if (grafo.MatrizAdjacencia[no, i] != 0 && visitados[i] == 0)
                    {
                        visitados[i] = 1;
                        fila.Enqueue(i);
                    }
                }
                try
                {
                    no = (int)fila.Dequeue();
                }
                catch (global::System.Exception)
                { 
                    break;
                }
            } while (true);
        }
    }
}