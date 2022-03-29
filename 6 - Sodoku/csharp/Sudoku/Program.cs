using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeDoArquivoSudoku;
            Console.Write("Qual o nome (caminho) do arquivo com um cenário sudoku inicial? ");
            nomeDoArquivoSudoku = Console.ReadLine();

            Sudoku solucao1 = new Sudoku(9);

            if ( solucao1.populaDoArquivo(nomeDoArquivoSudoku) )
            {
                solucao1.exibirSudoku();
            }

            
        }
    }
}
