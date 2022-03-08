using System;
namespace MovimentaTeclado
{
    public class Movimenta
    {

        public static void localizaZero(int[,] matriz, ref int lz, ref int cz, int dimensao) {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if (matriz[i,j] == 0)
                    {
                        lz = i;
                        cz = j;
                    }
                }
            }
        }
        public static void moverEsquerda(int[,] matriz, int dimensao)
        {
            int linhaZero = 0;
            int colunaZero = 0;

            localizaZero(matriz, ref linhaZero, ref colunaZero, dimensao);

            Console.WriteLine("Posição do zero: " + linhaZero + "," + colunaZero);

            if (colunaZero > 0)
            {
                matriz[linhaZero, colunaZero] = matriz[linhaZero, colunaZero-1];
                matriz[linhaZero, colunaZero-1] = 0;

                colunaZero--;
            }
        }

        public static void moverDireita(int[,] matriz, int dimensao)
        {
            int linhaZero = 0;
            int colunaZero = 0;

            localizaZero(matriz, ref linhaZero, ref colunaZero, dimensao);
            Console.WriteLine("Posição do zero: " + linhaZero + "," + colunaZero);

            if (colunaZero < dimensao - 1)
            {
                matriz[linhaZero, colunaZero] = matriz[linhaZero, colunaZero+1];
                matriz[linhaZero, colunaZero+1] = 0;

                colunaZero++;
            }
        }

        public static void moverCima(int[,] matriz, int dimensao)
        {
            int linhaZero = 0;
            int colunaZero = 0;

            localizaZero(matriz, ref linhaZero, ref colunaZero, dimensao);

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

            localizaZero(matriz,ref linhaZero, ref colunaZero, dimensao);

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
