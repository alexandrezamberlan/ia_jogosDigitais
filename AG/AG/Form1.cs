using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_gerar_Click(object sender, EventArgs e)
        {
            tamanhoPopulacao = int.Parse(textBox_tamanhoPopulacao.Text);
            quantidadeGeracoes = int.Parse(textBox_quantidadGeracoes.Text);
            palavraFinal = textBox_palavraFinal.Text;
            textBox_resultados.Text = "";

            inicializarPopulacao(populacao, tamanhoPopulacao, palavraFinal);

            ordenarPopulacao(populacao); //decrescente pela aptidao

            textBox_resultados.AppendText("Geração 0\n");
            exibirPopulacao(populacao);


            for (int i = 1; i < quantidadeGeracoes; i++)
            {
                //    selecionarPopulacao(populacao, novaPopulacao, taxaSelecao)

                //    reproduzirPopulacao(populacao, novaPopulacao, taxaReproducao, palavraFinal)


                //    mutarPopulacao(novaPopulacao, palavraFinal) //verificar a taxa ou a frequencia

                //    ordenarPopulacao(novaPopulacao)
                textBox_resultados.AppendText("Geração " + i + "\n");
                //    exibirPopulacao(novaPopulacao)


                //    apagar(populacao)

                //    mover(novaPopulacao, populacao)

                //    apagar(novaPopulacao)

            }
        }

        private void inicializarPopulacao(List<Cromossomo> populacao, 
                                          int tamanhoPopulacao, 
                                          string palavraFinal)
        {
            string palavraTmp;
            for (int i = 0; i < tamanhoPopulacao; i++)
            {
                palavraTmp = Util.gerarPalavras(palavraFinal.Count());
                Thread.Sleep(30);
                populacao.Add(new Cromossomo(palavraTmp,palavraFinal));
            }
        }

        private void exibirPopulacao(List<Cromossomo> populacao)
        {
            for (int i = 0; i < populacao.Count; i++)
            {
                textBox_resultados.AppendText(populacao[i].aptidao + " - " +
                    populacao[i].valor + " - " + populacao[i].aptidaoPorcentagem + "\n");
            }
        }

        private void ordenarPopulacao(List<Cromossomo> populacao)
        {
            Boolean houveTroca;
            Cromossomo tmp;
            int i;

            do
            {
                houveTroca = false;
                for (i = 0; i < populacao.Count - 1; i++)
                {
                    if (populacao[i].aptidao < populacao[i + 1].aptidao)
                    {
                        houveTroca = true;
                        tmp = populacao[i];
                        populacao[i] = populacao[i + 1];
                        populacao[i + 1] = tmp;
                    }
                }
            } while (houveTroca == true);
        }

        int tamanhoPopulacao, quantidadeGeracoes, taxaSelecao,
        taxaReproducao, taxaMutacao;
        string palavraFinal;
        List<Cromossomo> populacao = new List<Cromossomo>();
        List<Cromossomo> novaPopulacao = new List<Cromossomo>();
    }

    
}
