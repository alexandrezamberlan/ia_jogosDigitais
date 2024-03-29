﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rainhas_Game
{
    /// <summary>
    /// classe que contém a estrutura de dados matriz quadrada de inteiros, representando o tabuleiro
    /// </summary>
    internal class Matriz
    {
        /// <summary>
        /// objeto matriz para o tabuleiro, que deve ser quadrada
        /// </summary>
        public int[,] matriz; //Valores 0 (ausência) ou 1 (presença)

        /// <summary>
        /// objeto com a quantidade de rainhas inseridas no tabuleiro
        /// </summary>
        public int qtdRainhas;

        /// <summary>
        /// objeto dimensão do tabuleiro (YxY - Quadrada)
        /// </summary>
        public int dimensaoMatriz;

        public int qtdRestricoesFalhas;

        
        /// <summary>
        /// construtor padrão
        /// </summary>
        /// <param name="dimensao">quantidade de linhas e colunas da matriz tabuleiro</param>
        public Matriz(int dimensao)
        {
            this.dimensaoMatriz = dimensao;
            this.matriz = new int[dimensao, dimensao];
            this.qtdRestricoesFalhas = 0;
           
            for(int i = 0; i < this.dimensaoMatriz; i++)
            {
                for(int j = 0; j < this.dimensaoMatriz; j++)
                {
                    this.matriz[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// construtor que recebe uma matriz, em geral um filho gerado no cruzamento, e calcula sua aptidao
        /// </summary>
        /// <param name="matriz"></param>
        public Matriz(int[,] matriz)
        {
            this.dimensaoMatriz = matriz.GetLength(0);
            this.matriz = new int[dimensaoMatriz, dimensaoMatriz];
            this.qtdRestricoesFalhas = 0;

            for (int lin = 0; lin < this.dimensaoMatriz; lin++)
            {
                for (int col = 0; col < this.dimensaoMatriz; col++)
                {
                    this.matriz[lin, col] = matriz[lin,col];
                }                
            }
            this.verificarRestricoes();
        }


        /// <summary>
        /// método para embaralhar a lista temporária e de inteiros
        /// </summary>
        /// <param name="lista">lista de inteiros</param>
        public void Shuffle(List<int> lista)
        {
            Random gerador = new Random();
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = gerador.Next(n + 1);
                int value = lista[k];
                lista[k] = lista[n];
                lista[n] = value;
            }
        }

        /// <summary>
        /// método que preenche totalmente de forma aleatória a matriz com a quantidade da dimensão da matriz
        /// </summary>
        public void preencherMatriz()
        {
            List<int> lista = new List<int>();
            for (int i = 1; i <= this.dimensaoMatriz * this.dimensaoMatriz; i++)
            {
                lista.Add(i);
            }
            //lista de N*N
            //1 2 3 4 5 6 7 8 9 ..... N*N

            //embaralhar e pegar os N primeiros
            //8 1 6 

            this.Shuffle(lista);
            lista.RemoveRange(this.dimensaoMatriz,(this.dimensaoMatriz * this.dimensaoMatriz)-this.dimensaoMatriz);
            
            lista.Sort();

            int contador = 0;
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    contador++;
                    if(lista.Contains(contador))
                    {
                        this.matriz[i, j] = 1;
                       
                    }
                }
            }
            this.qtdRainhas = this.dimensaoMatriz;
        }

        /// <summary>
        /// método para exibir a matriz tabuleiro
        /// </summary>
        /// <param name="frase"></param>
        public void exibirMatriz(string frase)
        {
            Console.WriteLine(frase + " Restrições: " + this.qtdRestricoesFalhas);
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// método que verifica se a quantidade de rainhas está certo
        /// </summary>
        /// <returns>retorna o total de rainhas presentes na matriz</returns>
        public int descobreQtdRainhas()
        {
            int contarRainhas = 0;
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    if (matriz[i,j] != 0)
                    {
                        contarRainhas++;
                    }
                }
            }
            return contarRainhas;
        }

        /// <summary>
        /// método que analisa linhas, colunas e diagonais a procura de mais de uma rainha nessa orientação. Caso encontre mais de uma rainha, adiciona restrições por
        /// rainhas na mesma linha, coluna, diagonal (principal e secundária)
        /// Em um Algoritmo Genético, o cálculo da aptidão ou do fitness.
        /// </summary>
        public void verificarRestricoes()
        {
            int totalRainhas = descobreQtdRainhas();
            if (totalRainhas != this.dimensaoMatriz)
            {
                this.qtdRestricoesFalhas = dimensaoMatriz * dimensaoMatriz + totalRainhas;
                return;
            }

            int contarRainhas;
            //analisar linhas
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    if (this.matriz[i, j] == 1)
                    {
                        contarRainhas++;
                    }
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }    
            }

            //analisar colunas
            for (int j = 0; j < this.dimensaoMatriz; j++)
            {
                contarRainhas = 0;
                for (int i = 0; i < this.dimensaoMatriz; i++)
                {
                    if (this.matriz[i, j] == 1)
                    {
                        contarRainhas++;
                    }
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }
            }

            // percorre a diagonal principal
            contarRainhas = 0;
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                if (this.matriz[i, i] == 1)
                {
                    contarRainhas++;
                }
            }
            if (contarRainhas > 1)
            {
                this.qtdRestricoesFalhas += contarRainhas;
            }


            //analisar as diagonais principais
            // percorre as diagonais acima da diagonal principal
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = 0;
                int col = i + 1;
                
                while (row < this.dimensaoMatriz && col < this.dimensaoMatriz)
                {
                    if (this.matriz[row, col] == 1)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col++;
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }
            }          

            // percorre as diagonais abaixo da diagonal principal
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = i + 1;
                int col = 0;
                while (row < this.dimensaoMatriz && col < this.dimensaoMatriz)
                {
                    if (this.matriz[row, col] == 1)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col++;
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }
            }

            //analisar as diagonais secundarias
            // analisa as diagonais acima da diagonal secundária
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = 0;
                int col = i;
                while (row < this.dimensaoMatriz && col >= 0)
                {
                    if (this.matriz[row, col] == 1)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col--;
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }
            }

            // analisa as diagonais abaixo da diagonal secundária
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = i;
                int col = this.dimensaoMatriz - 1;
                while (row < this.dimensaoMatriz && col >= 0)
                {
                    if (this.matriz[row, col] == 1)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col--;
                }
                if (contarRainhas > 1)
                {
                    this.qtdRestricoesFalhas += contarRainhas;
                }
            }
        }

        
        /// <summary>
        /// método que interrompe o Algoritmo Genético quando uma solução é encontrada, ou seja, quando a matriz não tem nenhuma restrição ferida.
        /// </summary>
        /// <returns></returns>
        public bool ehMeta()
        {
            return this.qtdRestricoesFalhas == 0;
        }
    }
}
