using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rainhas_Game
{
    internal class Matriz
    {
        /// <summary>
        /// objeto matriz para o tabuleiro, que deve ser quadrada
        /// </summary>
        int[,] matriz; //Valores 0 (ausência) ou 1 (presença)

        /// <summary>
        /// objeto com a quantidade de rainhas inseridas no tabuleiro
        /// </summary>
        int qtdRainhas;

        /// <summary>
        /// objeto dimensão do tabuleiro (YxY - Quadrada)
        /// </summary>
        int dimensaoMatriz;
        
        /// <summary>
        /// construtor padrão
        /// </summary>
        /// <param name="dimensao">quantidade de linhas e colunas da matriz tabuleiro</param>
        public Matriz(int dimensao)
        {
            this.dimensaoMatriz = dimensao;
            this.matriz = new int[dimensao, dimensao];
            this.qtdRainhas = dimensao;

           
            //inicializar a matriz com 0
            for(int i = 0; i < this.dimensaoMatriz; i++)
            {
                for(int j = 0; j < this.dimensaoMatriz; j++)
                {
                    this.matriz[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// método para exibir a matriz tabuleiro
        /// </summary>
        /// <param name="frase"></param>
        public void exibirMatriz(string frase)
        {
            Console.WriteLine(frase);
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //método validarMatriz
        public Boolean rainhaNoLugarCerto()
        {
            int contarRainhas;
            
            //analisar linhas
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                for (int j = 0; j < this.dimensaoMatriz; j++)
                {
                    if (this.matriz[i, j] != 0)
                    {
                        contarRainhas++;
                    }
                }
                if (contarRainhas > 1)
                {
                    return false;
                }    
            }

            //analisar colunas
            for (int j = 0; j < this.dimensaoMatriz; j++)
            {
                contarRainhas = 0;
                for (int i = 0; i < this.dimensaoMatriz; i++)
                {
                    if (this.matriz[i, j] != 0)
                    {
                        contarRainhas++;
                    }
                }
                if (contarRainhas > 1)
                {
                    return false;
                }
            }

            //analisar as diagonais principais
            // percorre as diagonais acima da diagonal principal
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = 1;
                int col = i + 1;
                
                while (row < this.dimensaoMatriz && col < this.dimensaoMatriz)
                {
                    if (this.matriz[row, col] != 0)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col++;
                }
                if (contarRainhas > 1)
                {
                    return false;
                }
            }

            // percorre a diagonal principal
            contarRainhas = 0;
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                if (this.matriz[i, i] != 0)
                {
                    contarRainhas++;
                }
            }
            if (contarRainhas > 1)
            {
                return false;
            }

            // percorre as diagonais abaixo da diagonal principal
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = i + 1;
                int col = 1;
                while (row < this.dimensaoMatriz && col < this.dimensaoMatriz)
                {
                    if (this.matriz[row, col] != 0)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col++;
                }
                if (contarRainhas > 1)
                {
                    return false;
                }
            }


            //analisar as diagonais secundarias
            // analisa as diagonais da primeira linha
            for (int i = 0; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = 0;
                int col = i;
                while (row < this.dimensaoMatriz && col >= 0)
                {
                    if (this.matriz[row, col] != 0)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col--;
                }
                if (contarRainhas > 1)
                {
                    return false;
                }
            }

            // analisa as diagonais da ultima coluna (exceto a diagonal principal)
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = i;
                int col = this.dimensaoMatriz - 1;
                while (row < this.dimensaoMatriz && col >= 0)
                {
                    if (this.matriz[row, col] != 0)
                    {
                        contarRainhas++;
                    }
                    row++;
                    col--;
                }
                if (contarRainhas > 1)
                {
                    return false;
                }
            }

            return true;
        }
        public Boolean resolveRainhas(int tentandoNumero) //metodo de profundidade para resolução via força bruta por empilhamento
        {
            for (int linha = 0; linha < this.dimensaoMatriz; linha++)
            {
                for (int coluna = 0; coluna < this.dimensaoMatriz; coluna++)
                {
                    if (this.matriz[linha, coluna] == 0)
                    {
                        this.matriz[linha, coluna] = tentandoNumero;
                        Console.WriteLine("Colocou o " + tentandoNumero);
                        if (rainhaNoLugarCerto())
                        {                            
                            this.exibirMatriz("temporaria");
                            tentandoNumero++;
                            if (resolveRainhas(tentandoNumero))
                            {
                                return true;
                            }
                            return false;
                        }
                        else
                        {
                            this.matriz[linha, coluna] = 0;
                            Console.WriteLine("vai para o proxima celula.....");
                        }
                        
                    }                   
                }
            }
            if (tentandoNumero == this.qtdRainhas)
            {
                return true;
            }
            return false;
        }
    }

}

