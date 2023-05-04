using Rainhas_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainhas_Game
{
    class MeusTestes
    {
        int[,] matriz;
        int n;
        public MeusTestes(int dimensao) 
        {
            this.matriz = new int[dimensao, dimensao];
            this.n = dimensao;



            int contador = 1;
            for (int lin = 0; lin < this.n; lin++)
            {
                for (int col = 0; col < this.n; col++)
                {                    
                    this.matriz[lin, col] = contador;
                    contador++;
                }
            }

            
        }
        public void exibirMatriz()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    Console.Write(this.matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void mostrarDiagonaisPrincipais()
        {
            // percorre as diagonais acima da diagonal principal
            for (int i = 1; i < n; i++)
            {
                Console.Write(this.matriz[0, i] + " ");
                int row = 1;
                int col = i + 1;
                while (row < n && col < n)
                {
                    Console.Write(this.matriz[row, col] + " ");
                    row++;
                    col++;
                }
                Console.WriteLine();
            }

            // percorre a diagonal principal
            for (int i = 0; i < n; i++)
            {
                Console.Write(this.matriz[i, i] + " ");
            }
            Console.WriteLine();

            // percorre as diagonais abaixo da diagonal principal
            for (int i = 1; i < n; i++)
            {
                Console.Write(this.matriz[i, 0] + " ");
                int row = i + 1;
                int col = 1;
                while (row < n && col < n)
                {
                    Console.Write(this.matriz[row, col] + " ");
                    row++;
                    col++;
                }
                Console.WriteLine();
            }

        }

        public void mostrarDiagonaisSecundarias()
        {
            // analisa as diagonais da primeira linha
            for (int i = 0; i < n; i++)
            {
                int row = 0;
                int col = i;
                while (row < n && col >= 0)
                {
                    Console.Write(this.matriz[row, col] + " ");
                    row++;
                    col--;
                }
                Console.WriteLine();
            }

            // analisa as diagonais da ultima coluna (exceto a diagonal principal)
            for (int i = 1; i < n; i++)
            {
                int row = i;
                int col = n - 1;
                while (row < n && col >= 0)
                {
                    Console.Write(this.matriz[row, col] + " ");
                    row++;
                    col--;
                }
                Console.WriteLine();
            }

        }
    }
}

