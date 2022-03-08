using System;

namespace MovimentaTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            int TAM = 3;
            int[,] matriz = new int[TAM, TAM];

            Util.sortearNumerosMatriz(matriz, TAM);

            Util.mostrarMatriz(matriz, TAM);

            char letra;
            int x;
            
            do {
                x = Console.Read();
                letra = Convert.ToChar(x);
                switch (letra)
                {   
                    case 'w' :
                        Console.WriteLine("Indo para cima");
                        Movimenta.moverCima(matriz, TAM);
                        break;
                    case 's' :
                        Console.WriteLine("Indo para baixo");
                        Movimenta.moverBaixo(matriz, TAM);
                        break;
                    case 'a' :
                        Console.WriteLine("Indo para esquerda");
                        Movimenta.moverEsquerda(matriz, TAM);
                        break;
                    case 'd' :
                        Console.WriteLine("Indo para direita");
                        Movimenta.moverDireita(matriz, TAM);
                        break;
                    
                }
                Util.mostrarMatriz(matriz, TAM);
            } while (letra != '1');
        }
    }
}
