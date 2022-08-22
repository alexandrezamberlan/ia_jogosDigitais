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

            Sudoku solucao1 = new Sudoku();

            if ( solucao1.popularDoArquivo(nomeDoArquivoSudoku) )
            {          
                solucao1.exibirSudoku("Arquivo de cenário localizado!");

                if (solucao1.resolveSudoku(1))
                {
                    solucao1.exibirSudoku("\n\nCenário resolvido com sucesso!");
                    Console.WriteLine("Todas as chamadas recursivas: " + solucao1.TotalChamadasNaoRecursivas);
                } else
                {
                    Console.WriteLine("Cenário não resolvido! A configuração inicial do sudoku está complexa!");
                }
            }

            
        }
    }
}
