using System;

namespace RNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de uso de RNA Perceptron!");
            Perceptron_And p = new Perceptron_And();
            p.treinar();
 
            Console.WriteLine("Para aprender o algoritmo treinou " + p.conta + " geracoes! \n ");
 
            p.testar();
        }
    }
}
