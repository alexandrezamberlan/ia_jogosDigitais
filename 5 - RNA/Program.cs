using System;
using System.Collections.Generic;

namespace RNA
{
    
    class Program
    {
        static double somatorio(List<Int32> e, List<Double> p) {
            double s = 0;

            for (int i = 0; i < e.Count; i++) {
                s = s + (e[i] * p[i]);
            }
            return s;
        }

        static int ativacaoStep(double soma) {
            if (soma >= 6) return 1;
            return 0;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Exemplo de uso de RNA Perceptron!");
            // Perceptron p = new Perceptron(10);
            // Console.WriteLine("Teste de saída: " + p.saida);

            List<Int32> entradas = new List<Int32>();
            List<Double> pesos = new List<Double>();

            entradas.Add(5);
            entradas.Add(3);
            entradas.Add(10);

            pesos.Add(0.3);
            pesos.Add(0.6);
            pesos.Add(0.1);

            double soma = somatorio(entradas, pesos);
            Console.WriteLine(soma);

            int ativar = ativacaoStep(soma);
            Console.WriteLine(ativar);

        }
    }
}
