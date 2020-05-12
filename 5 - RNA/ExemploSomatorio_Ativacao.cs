using System;
using System.Collections.Generic;


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
            if (soma >= 0) return 1;
            return 0;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Exemplo de uso de RNA Perceptron!");
            // Perceptron p = new Perceptron(10);
            // Console.WriteLine("Teste de saída: " + p.saida);

            
            List<Int32> entradas = new List<Int32>();
            List<Double> pesos = new List<Double>();
            //5 3 10
            entradas.Add(5);
            entradas.Add(3);
            entradas.Add(10);

            //0.3 0.6 0.1
            pesos.Add(0.3);
            pesos.Add(0.6);
            pesos.Add(0.1);

            double soma = somatorio(entradas, pesos);
            Console.WriteLine(soma);

            int ativar = ativacaoStep(soma);
            Console.WriteLine(ativar);


        }
    }
