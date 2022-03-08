using System;
using System.Collections.Generic;

namespace labirinto
{
    public class Estado
    {
        public String[,] matriz;
        public int posLinhaE;
        public int posColunaE;
        public int posLinhaS;
        public int posColunaS;

        public Estado()
        {

        }

        //construtor para o primeiro estado
        public Estado(int qtdLinhas, int qtdColunas, List<String> visitados)
        {
            matriz = new String[qtdLinhas, qtdColunas];
            Random gerador = new Random();

            int entrada = gerador.Next(qtdLinhas * qtdColunas); //5
            int saida;
            do
            {
                saida = gerador.Next(qtdLinhas * qtdColunas); //10
            } while (entrada == saida);

            int contaPosicoes = 0;
            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    if (contaPosicoes == entrada)
                    {
                        this.matriz[i, j] = "E";
                        this.posLinhaE = i;
                        this.posColunaE = j;
                    }
                    else if (contaPosicoes == saida)
                    {
                        this.matriz[i, j] = "S";
                        this.posLinhaS = i;
                        this.posColunaS = j;
                    }
                    else
                    {
                        this.matriz[i, j] = "0";
                    }
                    contaPosicoes++;
                }
            }

            /*
             * o o o e o o
             * o o o o o o
             * s o o o o o
             */

            String estadoGerado = "";
            //gravar o estado gerado em uma string para visitados
            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    estadoGerado = estadoGerado + this.matriz[i, j];
                }
            }
            if (!visitados.Contains(estadoGerado)) {
                visitados.Add(estadoGerado);
            }
            //visitados = ["oooeoooooooosooooo"][][][][][][]
        }


        private String geraEstado() //gera o stringao da matriz como um estado
        {
            String estadoGerado = "";
            //gravar o estado gerado em uma string para visitados
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    estadoGerado = estadoGerado + this.matriz[i, j];
                }
            }
            return estadoGerado;

        }

        public void irCima(List<String> visitados)
        {
            if (this.posLinhaE > 0)
            {
                this.matriz[this.posLinhaE, this.posColunaE] = "0";
                this.posLinhaE--;
                this.matriz[this.posLinhaE, this.posColunaE] = "E";
            }

            String estadoGerado = this.geraEstado();
            if (!visitados.Contains(estadoGerado))
            {
                visitados.Add(estadoGerado);
            }
            else
            {
                Console.WriteLine("Atenção... vc já foi neste estado ou nesta célula");
            }
        }

        public void irBaixo(List<String> visitados)
        {
            if (this.posLinhaE < this.matriz.GetLength(0))
            {
                this.matriz[this.posLinhaE, this.posColunaE] = "0";
                this.posLinhaE++;
                this.matriz[this.posLinhaE, this.posColunaE] = "E";
            }

            String estadoGerado = this.geraEstado();
            if (!visitados.Contains(estadoGerado))
            {
                visitados.Add(estadoGerado);
            }
            else
            {
                Console.WriteLine("Atenção... vc já foi neste estado ou nesta célula");
            }
        }

        public void irEsquerda(List<String> visitados)
        {
            if (this.posColunaE > 0)
            {
                this.matriz[this.posLinhaE, this.posColunaE] = "0";
                this.posColunaE--;
                this.matriz[this.posLinhaE, this.posColunaE] = "E";
            }
            String estadoGerado = this.geraEstado();
            if (!visitados.Contains(estadoGerado))
            {
                visitados.Add(estadoGerado);
            }
            else
            {
                Console.WriteLine("Atenção... vc já foi neste estado ou nesta célula");
            }
        }

        public void irDireita(List<String> visitados)
        { 
            if (this.posColunaE < this.matriz.GetLength(1))
            {
                this.matriz[this.posLinhaE, this.posColunaE] = "0";
                this.posColunaE++;
                this.matriz[this.posLinhaE, this.posColunaE] = "E";
            }
            String estadoGerado = this.geraEstado();
            if (!visitados.Contains(estadoGerado))
            {
                visitados.Add(estadoGerado);
            }
            else
            {
                Console.WriteLine("Atenção... vc já foi neste estado ou nesta célula");
            }
        }

        public Boolean ehMeta()
        {
            return this.posLinhaE == this.posLinhaS && this.posColunaE == this.posColunaS;
        }

        public void mostrar(List<String> visitados)
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    Console.Write(this.matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("ENTRADA está em: " + this.posLinhaE + "," + this.posColunaE);
            Console.WriteLine("SAÍDA está em  : " + this.posLinhaS + "," + this.posColunaS);
           
            for (int i = 0; i < visitados.Count; i++)
            {
                Console.WriteLine(visitados[i]);
            }
            Console.WriteLine("\n");
           
        }
    }
}

/*
0   1   2   3
4   5   6   7
8   9   10  11
12  13  14  15
*/