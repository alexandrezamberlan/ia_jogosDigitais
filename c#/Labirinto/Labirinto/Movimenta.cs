using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    class Movimenta
    {
        public static void irCima(Button botao)
        {
            if (botao.Bounds.Y > 0)
            {
                botao.SetBounds(botao.Bounds.X,
                            botao.Bounds.Y - 1,
                            botao.Bounds.Width,
                            botao.Bounds.Height);
            }
        }

        public static void irBaixo(Button botao, int altura)
        {
            if (botao.Bounds.Y < altura - 90)
            {
                botao.SetBounds(botao.Bounds.X,
                            botao.Bounds.Y + 1,
                            botao.Bounds.Width,
                            botao.Bounds.Height);
            }
        }

        public static void irEsquerda(Button botao)
        {
            if (botao.Bounds.X > 0)
            {
                botao.SetBounds(botao.Bounds.X - 1,
                            botao.Bounds.Y,
                            botao.Bounds.Width,
                            botao.Bounds.Height);
            }

        }

        public static void irDireita(Button botao, int largura)
        {
            if (botao.Bounds.X < largura - 40)
            {
                botao.SetBounds(botao.Bounds.X + 1,
                            botao.Bounds.Y,
                            botao.Bounds.Width,
                            botao.Bounds.Height);
            }
        }
    }
}
