namespace AG
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_gerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_tamanhoPopulacao = new System.Windows.Forms.TextBox();
            this.textBox_quantidadGeracoes = new System.Windows.Forms.TextBox();
            this.textBox_taxaSelecao = new System.Windows.Forms.TextBox();
            this.textBox_palavraFinal = new System.Windows.Forms.TextBox();
            this.textBox_taxaMutacao = new System.Windows.Forms.TextBox();
            this.textBox_resultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_gerar
            // 
            this.button_gerar.Location = new System.Drawing.Point(150, 155);
            this.button_gerar.Name = "button_gerar";
            this.button_gerar.Size = new System.Drawing.Size(75, 23);
            this.button_gerar.TabIndex = 0;
            this.button_gerar.Text = "Gerar";
            this.button_gerar.UseVisualStyleBackColor = true;
            this.button_gerar.Click += new System.EventHandler(this.button_gerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "População:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Palavra final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Taxa Mutação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Taxa Seleção:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantidade de Gerações:";
            // 
            // textBox_tamanhoPopulacao
            // 
            this.textBox_tamanhoPopulacao.Location = new System.Drawing.Point(136, 3);
            this.textBox_tamanhoPopulacao.Name = "textBox_tamanhoPopulacao";
            this.textBox_tamanhoPopulacao.Size = new System.Drawing.Size(100, 20);
            this.textBox_tamanhoPopulacao.TabIndex = 9;
            // 
            // textBox_quantidadGeracoes
            // 
            this.textBox_quantidadGeracoes.Location = new System.Drawing.Point(136, 34);
            this.textBox_quantidadGeracoes.Name = "textBox_quantidadGeracoes";
            this.textBox_quantidadGeracoes.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantidadGeracoes.TabIndex = 10;
            // 
            // textBox_taxaSelecao
            // 
            this.textBox_taxaSelecao.Location = new System.Drawing.Point(136, 67);
            this.textBox_taxaSelecao.Name = "textBox_taxaSelecao";
            this.textBox_taxaSelecao.Size = new System.Drawing.Size(100, 20);
            this.textBox_taxaSelecao.TabIndex = 11;
            // 
            // textBox_palavraFinal
            // 
            this.textBox_palavraFinal.Location = new System.Drawing.Point(136, 129);
            this.textBox_palavraFinal.Name = "textBox_palavraFinal";
            this.textBox_palavraFinal.Size = new System.Drawing.Size(100, 20);
            this.textBox_palavraFinal.TabIndex = 13;
            // 
            // textBox_taxaMutacao
            // 
            this.textBox_taxaMutacao.Location = new System.Drawing.Point(136, 98);
            this.textBox_taxaMutacao.Name = "textBox_taxaMutacao";
            this.textBox_taxaMutacao.Size = new System.Drawing.Size(100, 20);
            this.textBox_taxaMutacao.TabIndex = 14;
            // 
            // textBox_resultados
            // 
            this.textBox_resultados.Location = new System.Drawing.Point(4, 188);
            this.textBox_resultados.Multiline = true;
            this.textBox_resultados.Name = "textBox_resultados";
            this.textBox_resultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resultados.Size = new System.Drawing.Size(242, 260);
            this.textBox_resultados.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 450);
            this.Controls.Add(this.textBox_resultados);
            this.Controls.Add(this.textBox_taxaMutacao);
            this.Controls.Add(this.textBox_palavraFinal);
            this.Controls.Add(this.textBox_taxaSelecao);
            this.Controls.Add(this.textBox_quantidadGeracoes);
            this.Controls.Add(this.textBox_tamanhoPopulacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_gerar);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_tamanhoPopulacao;
        private System.Windows.Forms.TextBox textBox_quantidadGeracoes;
        private System.Windows.Forms.TextBox textBox_taxaSelecao;
        private System.Windows.Forms.TextBox textBox_palavraFinal;
        private System.Windows.Forms.TextBox textBox_taxaMutacao;
        private System.Windows.Forms.TextBox textBox_resultados;
    }
}

