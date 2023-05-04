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

        int qtdRestricoesFalhas;

        
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

        //método validarMatriz
        public void verificarRestricoes()
        {
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

            //analisar as diagonais principais
            // percorre as diagonais acima da diagonal principal
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = 1;
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

            // percorre as diagonais abaixo da diagonal principal
            for (int i = 1; i < this.dimensaoMatriz; i++)
            {
                contarRainhas = 0;
                int row = i + 1;
                int col = 1;
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
            // analisa as diagonais da primeira linha
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

            // analisa as diagonais da ultima coluna (exceto a diagonal principal)
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

        public bool ehMeta()
        {
            return this.qtdRestricoesFalhas == 0;
        }
    }
}
