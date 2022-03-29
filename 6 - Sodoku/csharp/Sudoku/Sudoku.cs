using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku
    {
        int[,] matriz;
        int dimensao;

        public Sudoku(int dimensao)
        {
            this.Dimensao = dimensao;
            this.Matriz = new int[dimensao, dimensao];
            this.inicializarMatriz();
        }

        public bool populaDoArquivo(string nomeDoArquivoSudoku)
        {            
            // To read the entire file at once
            if (File.Exists(nomeDoArquivoSudoku)) //o método de classe Exists() é invocado pela classe File
            {
                //le o conteúdo do arquivo linha por linha e armazena em uma lista/vetor de string
                string[] linhas = File.ReadAllLines(nomeDoArquivoSudoku);

                for (int i = 0; i < linhas.Length; i++)
                {
                    for (int j = 0; j < linhas.Length; j++)
                    {
                        this.Matriz[i, j] = Int32.Parse( linhas[i].Substring(j,1));
                    }
                }
                return true;
            } else
            {
                Console.WriteLine("Arquivo não localizado!!!");
                return false;
            }
        }

        private void inicializarMatriz()
        {
            for (int i = 0; i < this.Dimensao; i++)
            {
                for (int j = 0; j < this.Dimensao; j++)
                {
                    this.Matriz[i, j] = 0;
                }
            }
        }

        public int[,] Matriz { get => matriz; set => matriz = value; }
        public int Dimensao { get => dimensao; set => dimensao = value; }

        public void exibirSudoku()
        {
            for (int i = 0; i < this.Dimensao; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("-------------------");
                }
                for (int j = 0; j < Dimensao; j++)
                {
                    if (j % 3 == 0 && j != 0)
                    {
                        Console.Write("|");
                    }
                    Console.Write(this.Matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
