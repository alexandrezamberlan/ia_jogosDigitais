using System;
namespace PreparandoParaIA_jogos
{
    public class Movimenta
    {

        public static void moverCima(int[,] matriz, int dimensao)
        {
            int linhaZero = 0;
            int colunaZero = 0;

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if (matriz[i,j] == 0)
                    {
                        linhaZero = i;
                        colunaZero = j;
                    }
                }
            }
            Console.WriteLine("Posição do zero: " + linhaZero + "," + colunaZero);

            if (linhaZero > 0)
            {
                matriz[linhaZero, colunaZero] = matriz[linhaZero-1, colunaZero];
                matriz[linhaZero-1, colunaZero] = 0;

                linhaZero--;
            }
        }

        public static void moverBaixo(int[,] matriz, int dimensao)
        {
            int linhaZero = 0;
            int colunaZero = 0;

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if (matriz[i,j] == 0)
                    {
                        linhaZero = i;
                        colunaZero = j;
                    }
                }
            }
            Console.WriteLine("Posição do zero: " + linhaZero + "," + colunaZero);

            if (linhaZero < dimensao - 1)
            {
                matriz[linhaZero, colunaZero] = matriz[linhaZero+1, colunaZero];
                matriz[linhaZero+1, colunaZero] = 0;

                linhaZero++;
            }
        }
    }
}
