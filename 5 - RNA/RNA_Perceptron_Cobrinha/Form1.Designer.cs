namespace RNA_Perceptron_Cobrinha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_cabeca = new System.Windows.Forms.Button();
            this.button_fruta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cabeca
            // 
            this.button_cabeca.Location = new System.Drawing.Point(334, 114);
            this.button_cabeca.Name = "button_cabeca";
            this.button_cabeca.Size = new System.Drawing.Size(33, 31);
            this.button_cabeca.TabIndex = 0;
            this.button_cabeca.Text = "@";
            this.button_cabeca.UseVisualStyleBackColor = true;
            this.button_cabeca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_cabeca_KeyDown);
            // 
            // button_fruta
            // 
            this.button_fruta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_fruta.Enabled = false;
            this.button_fruta.Location = new System.Drawing.Point(384, 210);
            this.button_fruta.Name = "button_fruta";
            this.button_fruta.Size = new System.Drawing.Size(33, 31);
            this.button_fruta.TabIndex = 1;
            this.button_fruta.TabStop = false;
            this.button_fruta.Text = "!";
            this.button_fruta.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fruta);
            this.Controls.Add(this.button_cabeca);
            this.Name = "Form1";
            this.Text = "RNA Cobrinha";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_cabeca;
        private Button button_fruta;
    }
}