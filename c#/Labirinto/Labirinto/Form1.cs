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
                    matriz[i,j] = 0;
                }
            }
            //sortear 1s em 10% da matriz, representando paredes
            int qtdParedes = 20;
            Random gerador = new Random();
            int linha;
            int coluna;
            for (int i = 0; i < qtdParedes; i++)
            {
                linha = gerador.Next(matriz.GetLength(0) - tamanhoParede);
                coluna = gerador.Next(matriz.GetLength(1) - tamanhoParede);
                for (int l = linha; l < linha + tamanhoParede; l++)
                {
                    for (int c = coluna; c < coluna + tamanhoParede; c++)
                    {
                        if (matriz[l,c] == 0) matriz[l, c] = 1;
                    }
                }
                
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)

                {
                    Console.Write(matriz[i, j] + "  "); 
                }
                Console.WriteLine();
            }

            
            //plotar ou desenhar o labirinto
            //botões representarão as paredes.
            List<Button> paredes = new List<Button>();

            for (int i = 1; i < qtdLinhas; i++)
            {
                for (int j = 1; j < qtdColunas; j++)
                {
                    if (matriz[i,j] == 1)
                    {
                        paredes.Add(new Button());

                        paredes.Last().SetBounds(j, i, tamanhoParede, tamanhoParede);

                        paredes.Last().BackColor = Color.Black;

                        panel_matriz.Controls.Add(paredes.Last());
                    }
                }
            }

            button_jogador.SetBounds(0,0,15,15);
            linhaJogador = 0;
            colunaJogador = 0;
           
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

        private void button_jogador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w': //ir para cima
                    if (linhaJogador > 0 && matriz[linhaJogador - 1, colunaJogador] == 0)
                    {
                        Movimenta.irCima(button_jogador);
                        linhaJogador--;
                    }
                    break;
                case 's': //ir para baixo
                    if (linhaJogador < matriz.GetLength(0) && matriz[linhaJogador + 1, colunaJogador] == 0)
                    {
                        Movimenta.irBaixo(button_jogador, this.Bounds.Height);
                        linhaJogador++;
                    }                    
                    break;
                case 'a': //ir para esquera
                    Movimenta.irEsquerda(button_jogador);
                    break;
                case 'd': //ir para direita
                    Movimenta.irDireita(button_jogador, this.Bounds.Width);
                    break;           
            }
        }
    }
}
