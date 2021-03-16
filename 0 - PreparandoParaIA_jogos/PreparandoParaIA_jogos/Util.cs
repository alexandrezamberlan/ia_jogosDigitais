using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace PreparandoParaIA_jogos
{
    public static class Util
    {
        

        public static void embaralhar<T>(this IList<T> list)
        {
            Random gerador = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = gerador.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void sortearNumerosMatriz(int[,] matriz, int dimensao)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < dimensao * dimensao; i++)
            {
                lista.Add(i);
            }

            //embaralhou a lista
            embaralhar(lista);

            int c = 0;
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz[i, j] = lista[c];
                    c++;
                }
            }
        }

        public static void mostrarMatriz(int[,] matriz, int dimensao)
        {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
