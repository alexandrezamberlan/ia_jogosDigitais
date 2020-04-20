using System;
using System.Collections.Generic;
using System.Linq;


static class Program
{
    static void Main()
    {
        Console.WriteLine("Algoritmos Genéticos");
        List<Cromossomo> populacao = new List<Cromossomo>();
        List<Cromossomo> novaPopulacao = new List<Cromossomo>();

        String estadoFinal;
        int quantidadeGeracoes;
        int taxaSelecao;
        int taxaReproducao;
        int taxaMutacao;
        int tamanhoPopulacao;

        Console.Write("Qual a palavra ou frase que quer testar como estado final? ");
        estadoFinal = Console.ReadLine();

        Console.Write("Quantas gerações pretende executar? "); //serve para o for
        quantidadeGeracoes = Int32.Parse( Console.ReadLine() );

        Console.Write("Taxa de seleção (10-90): ");
        taxaSelecao = Int32.Parse( Console.ReadLine() );
        taxaReproducao = 100 - taxaSelecao;

        Console.Write("Taxa de mutação (1-5%): ");
        taxaMutacao = Int32.Parse( Console.ReadLine() );

        Console.Write("Tamanho da população: ");
        tamanhoPopulacao = Int32.Parse( Console.ReadLine() );

        //gerar população inicial
        //calcular aptidao para cada estado/indivíduo/cromossomo da população
        popular(populacao,tamanhoPopulacao,estadoFinal);
        ordenar(populacao); //decrescente pela aptidao
        Console.WriteLine("Geração 0");
        exibir(populacao);


        for (int i = 1; i < quantidadeGeracoes; i++)
        {
            //selecionar

            //reproduzir

            //mutar
            
            ordenar(populacao); //decrescente pela aptidao
            Console.WriteLine("Geração " + i);
            exibir(populacao);
        }
    }
}
