using System;
using System.Collections.Generic;

namespace labirinto
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Jogo do labirinto");

            List<String> visitados = new List<string>();

            int qtdLinhas = 5;
            int qtdColunas = 5;

            Estado estadoInicial = new Estado(qtdLinhas, qtdColunas, visitados);
            estadoInicial.mostrar(visitados);

            Estado estadoIntermediario = estadoInicial;
            char tecla;
            int toques = 0;
            do
            {
                tecla = Console.ReadKey().KeyChar;
                toques++;
                switch (tecla)
                {
                    case 'w':
                        Console.WriteLine("Ir para cima");
                        estadoIntermediario.irCima(visitados);
                        break;
                    case 's':
                        Console.WriteLine("Ir para baixo");
                        estadoIntermediario.irBaixo(visitados);
                        break;
                    case 'a':
                        Console.WriteLine("Ir para esquerda");
                        estadoIntermediario.irEsquerda(visitados);
                        break;
                    case 'd':
                        Console.WriteLine("Ir para direita");
                        estadoIntermediario.irDireita(visitados);
                        break;
                    default:
                        break;
                }
                //mostrar
                estadoIntermediario.mostrar(visitados);
            } while (!estadoIntermediario.ehMeta());
            Console.WriteLine("Parabéns... você saiu do labirinto com " + toques + " toques no teclado");

        }
    }
}
