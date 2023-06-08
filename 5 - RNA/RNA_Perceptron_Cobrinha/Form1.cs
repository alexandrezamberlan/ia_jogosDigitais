namespace RNA_Perceptron_Cobrinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button_cabeca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    //ir para esquerda
                    Thread.CurrentThread.Interrupt();
                    new Thread(() => {
                        while (Movimento.irEsquerda(button_cabeca))
                        {
                            Thread.Sleep(1000);
                        }
                    }).Start(); 
                    break;
                case Keys.D:
                    //ir para direita
                    Thread.CurrentThread.Interrupt();
                    new Thread(() =>
                    {
                        while (Movimento.irDireita(button_cabeca, this))
                        {
                            Thread.Sleep(1000);
                        }
                    }).Start();
                    break;
                case Keys.W:
                    //ir para cima
                    Thread.CurrentThread.Interrupt();
                    new Thread(() =>
                    {
                        while (Movimento.irCima(button_cabeca))
                        {
                            Thread.Sleep(1000);
                        }
                    }).Start();
                    break;
                case Keys.S:
                    //ir para baixo
                    Thread.CurrentThread.Interrupt();
                    new Thread(() =>
                    {
                        while (Movimento.irBaixo(button_cabeca, this))
                        {
                            Thread.Sleep(1000);
                        }
                    }).Start();
                    break;
                default:
                    break;
            }

            if (button_cabeca.Bounds.IntersectsWith(button_fruta.Bounds))
            {
                Movimento.sorteiaPosicao(button_fruta, this);
            }
        }
    }
}