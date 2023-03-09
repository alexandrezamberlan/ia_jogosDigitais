using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Busca
{
    public class Grafo
    {
        public int QuantidadeVertices { get; set; } //nodos ou nos do grafo
        public int QuantidadeArestas { get; set; }  //arcos ou linhas do grafo
        public int[,] MatrizAdjacencia { get; set; }

        public Grafo(int quantidadeVertices)
        {
            QuantidadeArestas = 0;
            QuantidadeVertices = quantidadeVertices;

            MatrizAdjacencia = new int[QuantidadeVertices, QuantidadeVertices];

            for (int i = 0; i < QuantidadeVertices; i++)
            {
                for (int j = 0; j < QuantidadeVertices; j++)
                {
                    MatrizAdjacencia[i, j]  = 0;
                }
            }
        }

        public void exibirGrafo(List<string> lista)
        {
            
            for (int i = 0; i < QuantidadeVertices; i++)
            {
                Console.Write(lista[i] + ": ");
                for (int j = 0; j < QuantidadeVertices; j++)
                {
                    if (MatrizAdjacencia[i, j] != 0)
                    {
                        Console.Write(lista[j] +"(" + MatrizAdjacencia[i, j] + ") ");
                    }

                }
                Console.WriteLine();
            }
        }

        public void inserirAssimetrico(int origem, int destino, int custo)
        {
            if (MatrizAdjacencia[origem, destino] == 0)
            {
                MatrizAdjacencia[origem, destino] = custo;
                QuantidadeArestas++;
            }
        }

        public void inserirSimetrico(int origem, int destino, int custo)
        {
            if (MatrizAdjacencia[origem, destino] == 0)
            {
                MatrizAdjacencia[origem, destino] = custo;
                MatrizAdjacencia[destino, origem] = custo;

                QuantidadeArestas+=2;
            }
        }
    }
}
