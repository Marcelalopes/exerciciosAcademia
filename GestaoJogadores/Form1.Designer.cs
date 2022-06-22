namespace GestaoJogadores
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_lista = new System.Windows.Forms.Label();
            this.textBox_lista = new System.Windows.Forms.TextBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(43, 40);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(91, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome do jogador:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(155, 40);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(200, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_lista
            // 
            this.label_lista.AutoSize = true;
            this.label_lista.Location = new System.Drawing.Point(577, 40);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(158, 13);
            this.label_lista.TabIndex = 2;
            this.label_lista.Text = "Lista de Jogadores Cadastrados";
            // 
            // textBox_lista
            // 
            this.textBox_lista.Enabled = false;
            this.textBox_lista.Location = new System.Drawing.Point(559, 80);
            this.textBox_lista.Multiline = true;
            this.textBox_lista.Name = "textBox_lista";
            this.textBox_lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_lista.Size = new System.Drawing.Size(196, 148);
            this.textBox_lista.TabIndex = 3;
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(155, 80);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 4;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gravar_click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(280, 80);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 5;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.limpar_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.textBox_lista);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Name = "Form1";
            this.Text = "Formulário de Gestaõ de Jogadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.TextBox textBox_lista;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_limpar;
    }
}

