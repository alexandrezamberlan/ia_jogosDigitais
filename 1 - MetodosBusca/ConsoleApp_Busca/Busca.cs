using System;
using System.Collections;

namespace ConsoleApp_Busca
{
    public class Busca
    {
        static int[] visitados;
        static Queue<int> fila;


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