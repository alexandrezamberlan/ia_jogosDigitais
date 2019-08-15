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

            MessageBox.Show(qtdLinhas + "x" + qtdColunas);

            //inicializar a matriz
            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    matriz[i,j] = 0;
                }
            }
            //MessageBox.Show("Dimensão matriz: " + matriz.Length);

            //sortear 1s em 10% da matriz, representando paredes
            int percentualLabirinto = 1;
            Random gerador = new Random();
            int linha;
            int coluna;
            for (int i = 0; i < 500; i++)
            {
                linha = gerador.Next(matriz.GetLength(0));
                coluna = gerador.Next(matriz.GetLength(1));
                matriz[linha, coluna] = 1;
            }
            //plotar ou desenhar o labirinto
            //botões representarão as paredes.
            List<Button> paredes = new List<Button>();

            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    if (matriz[i,j] == 1)
                    {
                        paredes.Add(new Button());

                        paredes.Last().SetBounds(j, i, 5, 5);
                        paredes.Last().Text = j + "," + i;

                        panel_matriz.Controls.Add(paredes.Last());
                    }
                }
            }

            button_jogador.SetBounds(0,0,15,15);
            //button_jogador.SetBounds.BackColor = "red";

            panel_matriz.Controls.Add(button_jogador);

            
        }

        int qtdLinhas;
        int qtdColunas;
        int[,] matriz;
        Button button_jogador = new Button();

    }
}
