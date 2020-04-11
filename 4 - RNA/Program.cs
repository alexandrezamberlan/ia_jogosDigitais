using System;

namespace RNA
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de uso de RNA Perceptron!");
            Perceptron p = new Perceptron(10);
            Console.WriteLine("Teste de saída: " + p.saida);
        }
    }
}
