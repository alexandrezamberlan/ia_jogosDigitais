using System;
using System.Collections.Generic;

namespace PerceptronChuva
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Exemplo de RNA Perceptron para classificação de equipes");
			List<Clima> amostras = new List<Clima>();
			//presencaNuvens; //0 a 5 -> 0 sem nuvens, 5 muitas nuvens
			//sensacaoTermica; //0 a 5 -> 0 frio, 5 quente
			//estacaoAno; //1, 2, 3, 4 -> 1 outono, 2 - inverno, 3 - primavera, 4 - verao
			amostras.Add(new Clima(5, 2, 1));
			amostras.Add(new Clima(4, 3, 1));
			amostras.Add(new Clima(3, 4, 1));
			amostras.Add(new Clima(0, 0, 1));
			amostras.Add(new Clima(4, 4, 1));
			amostras.Add(new Clima(3, 3, 1));
			amostras.Add(new Clima(3, 4, 2));
			amostras.Add(new Clima(3, 0, 2));

			List<Int32> saidas = new List<int>();
			saidas.AddRange(new Int32[]{1,-1, 1, -1, 1, 1, 1, -1});

			double taxa_aprendizado = 0.1;
			int geracoes = 1000;
			int limiar = 1;
			Perceptron p = new Perceptron(amostras, saidas, taxa_aprendizado, geracoes, limiar);

			p.treinar();

			while (true)
			{
				Console.Write("\nPresencaNuvens; //0 a 5 -> 0 sem nuvens, 5 muitas nuvens: ");
				int presencaNuvens = int.Parse(Console.ReadLine());
				Console.Write("SensacaoTermica; //0 a 5 -> 0 frio, 5 quente: ");
				int sensacaoTermica = int.Parse(Console.ReadLine());
				Console.Write("Estação ano: -> 1 outono, 2 - inverno, 3 - primavera, 4 - verao: ");
				int estacaoAno = int.Parse(Console.ReadLine());

				p.testar(new Clima(presencaNuvens, sensacaoTermica, estacaoAno));
			}
		}
    }
}
