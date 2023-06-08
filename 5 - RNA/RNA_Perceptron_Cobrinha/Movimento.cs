using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNA_Perceptron_Cobrinha
{
    internal class Movimento
    {
        public static void sorteiaPosicao(Button botao, Form tela)
        {
            Random gerador = new Random();

            botao.SetBounds(gerador.Next(0, tela.Width - 50), gerador.Next(0, tela.Height - 50), botao.Width, botao.Height);
        }

        public static bool irEsquerda(Button botao)
        {
            if (botao.Bounds.X > 0)
            {
                botao.SetBounds(botao.Bounds.X - 20, botao.Bounds.Y, botao.Width, botao.Height);
                return true;
            }
            return false;
        }

        public static bool irDireita(Button botao, Form tela)
        {
            if (botao.Bounds.X < tela.Width - 50)
            {
                botao.SetBounds(botao.Bounds.X + 20, botao.Bounds.Y, botao.Width, botao.Height);
                return true;
            }
            return false;
        }

        public static bool irCima(Button botao)
        {
            if (botao.Bounds.Y > 0)
            {
                botao.SetBounds(botao.Bounds.X, botao.Bounds.Y - 20, botao.Width, botao.Height);
                return true;
            }
            return false;
        }

        public static bool irBaixo(Button botao, Form tela)
        {
            if (botao.Bounds.Y < tela.Height - 90)
            {
                botao.SetBounds(botao.Bounds.X, botao.Bounds.Y + 20, botao.Width, botao.Height);
                return true;
            }
            return false;
        }
    }
}
