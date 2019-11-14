using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarLabirintoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qtdLinhas = panel_matriz.Height;
            qtdColunas = panel_matriz.Width;
            matriz = new int[qtdLinhas, qtdColunas];

            //inicializar a matriz
            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    matriz[i, j] = 0;
                }
            }
            //sortear 1s em 10% da matriz, representando paredes
            int qtdParedes = 20;
            Random gerador = new Random();
            int linha;
            int coluna;


            //por na matriz numero 1
            for (int i = 0; i < qtdParedes; i++)
            {
                linha = gerador.Next(matriz.GetLength(0) - tamanhoParede);
                coluna = gerador.Next(matriz.GetLength(1) - tamanhoParede);
                for (int l = linha; l < linha + tamanhoParede; l++)
                {
                    for (int c = coluna; c < coluna + tamanhoParede; c++)
                    {
                        if (matriz[l, c] == 0) matriz[l, c] = 1;
                    }
                }
                matriz[linha, coluna] = 2;
            }


            //plotar ou desenhar o labirinto
            //botões representarão as paredes.
            List<Button> paredes = new List<Button>();

            for (int i = 1; i < qtdLinhas; i++)
            {
                for (int j = 1; j < qtdColunas; j++)
                {
                    if (matriz[i, j] == 2)
                    {
                        paredes.Add(new Button());

                        paredes.Last().SetBounds(j, i, tamanhoParede, tamanhoParede);

                        paredes.Last().BackColor = Color.Black;

                        panel_matriz.Controls.Add(paredes.Last());
                    }
                }
            }


            

            button_jogador.SetBounds(0, 0, 10, 10);
            linhaJogador = 0;
            colunaJogador = 0;

            linha = gerador.Next(matriz.GetLength(0) - tamanhoParede);
            coluna = gerador.Next(matriz.GetLength(1) - tamanhoParede);

            MessageBox.Show(linha + "    " + coluna);
        
            for (int l = linha; l < linha + 10; l++)
            {
                for (int c = coluna; c < coluna + 10; c++)
                {
                    if (matriz[l, c] == 0) matriz[l, c] = 3;
                }
            }
            matriz[linha, coluna] = 4;

            button_saida.SetBounds(linha, coluna, button_saida.Width, button_saida.Height);
            button_saida.Visible = true;



            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)

                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }

            //button_jogador.SetBounds.BackColor = "red";

            panel_matriz.Controls.Add(button_jogador);
            button_jogador.Visible = true;
            button_jogador.Focus();

        }

        int qtdLinhas;
        int qtdColunas;
        int[,] matriz;
        int linhaJogador, colunaJogador;
        int tamanhoParede = 10;

        private void Panel_matriz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_jogador_Click(object sender, EventArgs e)
        {

        }

        private void button_jogador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w': //ir para cima
                    if (linhaJogador > 0 && matriz[linhaJogador - 1, colunaJogador] == 0)
                    {
                        if (matriz[linhaJogador - 1, colunaJogador + 1] == 0 && matriz[linhaJogador - 1, colunaJogador + 2] == 0 && matriz[linhaJogador - 1, colunaJogador + 3] == 0 && matriz[linhaJogador - 1, colunaJogador + 4] == 0 &&
                           matriz[linhaJogador - 1, colunaJogador + 5] == 0 && matriz[linhaJogador - 1, colunaJogador + 6] == 0 && matriz[linhaJogador - 1, colunaJogador + 7] == 0 && matriz[linhaJogador - 1, colunaJogador + 8] == 0 && matriz[linhaJogador - 1, colunaJogador + 9] == 0)
                        {
                            Movimenta.irCima(button_jogador);
                            linhaJogador--;
                        }
                    }
                    break;
                case 's': //ir para baixo
                    if (linhaJogador < matriz.GetLength(0) && matriz[linhaJogador + 9, colunaJogador] == 0)
                    {
                        if (matriz[linhaJogador + 9, colunaJogador + 1] == 0 && matriz[linhaJogador + 9, colunaJogador + 2] == 0 && matriz[linhaJogador + 9, colunaJogador + 3] == 0 && matriz[linhaJogador + 9, colunaJogador + 4] == 0 &&
                           matriz[linhaJogador + 9, colunaJogador + 5] == 0 && matriz[linhaJogador + 9, colunaJogador + 6] == 0 && matriz[linhaJogador + 9, colunaJogador + 7] == 0 && matriz[linhaJogador + 9, colunaJogador + 8] == 0 && matriz[linhaJogador + 9, colunaJogador + 9] == 0)
                        {
                            Movimenta.irBaixo(button_jogador, this.Bounds.Height);
                            linhaJogador++;
                        }

                    }
                    break;
                case 'a': //ir para esquerda
                    if (colunaJogador > 0 && matriz[linhaJogador, colunaJogador - 1] == 0)
                    {
                        if (matriz[linhaJogador + 1, colunaJogador - 1] == 0 && matriz[linhaJogador + 2, colunaJogador - 1] == 0 && matriz[linhaJogador + 3, colunaJogador - 1] == 0 && matriz[linhaJogador + 4, colunaJogador - 1] == 0 &&
                           matriz[linhaJogador + 5, colunaJogador - 1] == 0 && matriz[linhaJogador + 6, colunaJogador - 1] == 0 && matriz[linhaJogador + 7, colunaJogador - 1] == 0 && matriz[linhaJogador + 8, colunaJogador - 1] == 0 && matriz[linhaJogador + 9, colunaJogador - 1] == 0)
                        {
                            Movimenta.irEsquerda(button_jogador);
                            colunaJogador--;
                        }

                    }

                    break;
                case 'd': //ir para direita
                    if (colunaJogador < matriz.GetLength(1) && matriz[linhaJogador, colunaJogador + 9] == 0)
                    {
                        if (matriz[linhaJogador + 1, colunaJogador + 9] == 0 && matriz[linhaJogador + 2, colunaJogador + 9] == 0 && matriz[linhaJogador + 3, colunaJogador + 9] == 0 && matriz[linhaJogador + 4, colunaJogador + 9] == 0 &&
                           matriz[linhaJogador + 5, colunaJogador + 9] == 0 && matriz[linhaJogador + 6, colunaJogador + 9] == 0 && matriz[linhaJogador + 7, colunaJogador + 9] == 0 && matriz[linhaJogador + 8, colunaJogador + 9] == 0 && matriz[linhaJogador + 9, colunaJogador + 9] == 0)
                        {
                            Movimenta.irDireita(button_jogador, this.Bounds.Width);
                            colunaJogador++;
                        }

                    }

                    break;
                case 'f':
                    MessageBox.Show("Linha: " + linhaJogador + "\nColuna: " + colunaJogador + "\nPosicao: " + matriz[linhaJogador, colunaJogador]);
                    break;
            }

            if (button_jogador.Bounds.IntersectsWith(button_saida.Bounds))
            {
                MessageBox.Show("sai");
            }

        }
    }
}
