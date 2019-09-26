namespace Labirinto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarLabirintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_matriz = new System.Windows.Forms.Panel();
            this.button_jogador = new System.Windows.Forms.Button();
            this.button_saida = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_matriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarLabirintoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gerarLabirintoToolStripMenuItem
            // 
            this.gerarLabirintoToolStripMenuItem.Name = "gerarLabirintoToolStripMenuItem";
            this.gerarLabirintoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerarLabirintoToolStripMenuItem.Text = "Gerar Labirinto";
            this.gerarLabirintoToolStripMenuItem.Click += new System.EventHandler(this.gerarLabirintoToolStripMenuItem_Click);
            // 
            // panel_matriz
            // 
            this.panel_matriz.Controls.Add(this.button_saida);
            this.panel_matriz.Controls.Add(this.button_jogador);
            this.panel_matriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_matriz.Location = new System.Drawing.Point(0, 24);
            this.panel_matriz.Name = "panel_matriz";
            this.panel_matriz.Size = new System.Drawing.Size(800, 426);
            this.panel_matriz.TabIndex = 1;
            this.panel_matriz.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_matriz_Paint);
            // 
            // button_jogador
            // 
            this.button_jogador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_jogador.Location = new System.Drawing.Point(333, 304);
            this.button_jogador.Name = "button_jogador";
            this.button_jogador.Size = new System.Drawing.Size(15, 17);
            this.button_jogador.TabIndex = 0;
            this.button_jogador.UseVisualStyleBackColor = false;
            this.button_jogador.Visible = false;
            this.button_jogador.Click += new System.EventHandler(this.button_jogador_Click);
            this.button_jogador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_jogador_KeyPress_1);
            // 
            // button_saida
            // 
            this.button_saida.Location = new System.Drawing.Point(650, 372);
            this.button_saida.Name = "button_saida";
            this.button_saida.Size = new System.Drawing.Size(77, 23);
            this.button_saida.TabIndex = 1;
            this.button_saida.Text = "Saida";
            this.button_saida.UseVisualStyleBackColor = true;
            this.button_saida.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_matriz);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Labirinto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_matriz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarLabirintoToolStripMenuItem;
        private System.Windows.Forms.Panel panel_matriz;
        private System.Windows.Forms.Button button_jogador;
        private System.Windows.Forms.Button button_saida;
    }
}

