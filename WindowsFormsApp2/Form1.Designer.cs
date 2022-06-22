namespace WindowsFormsApp2
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
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbFabricante = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.Label();
            this.clbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lbPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(141, 12);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(238, 20);
            this.tbModelo.TabIndex = 0;
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(141, 57);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(238, 20);
            this.tbFabricante.TabIndex = 1;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(21, 18);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(88, 13);
            this.lbModelo.TabIndex = 3;
            this.lbModelo.Text = "Modelo do Carro:";
            this.lbModelo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFabricante
            // 
            this.lbFabricante.AutoSize = true;
            this.lbFabricante.Location = new System.Drawing.Point(21, 64);
            this.lbFabricante.Name = "lbFabricante";
            this.lbFabricante.Size = new System.Drawing.Size(102, 13);
            this.lbFabricante.TabIndex = 4;
            this.lbFabricante.Text = "Fabricante do carro:";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.AutoSize = true;
            this.lbOpcionais.Location = new System.Drawing.Point(21, 106);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(57, 13);
            this.lbOpcionais.TabIndex = 5;
            this.lbOpcionais.Text = "Opcionais:";
            // 
            // clbOpcionais
            // 
            this.clbOpcionais.FormattingEnabled = true;
            this.clbOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidráulica",
            "Freios ABS",
            "Air Bag",
            "Vidros elétricos"});
            this.clbOpcionais.Location = new System.Drawing.Point(141, 106);
            this.clbOpcionais.Name = "clbOpcionais";
            this.clbOpcionais.Size = new System.Drawing.Size(238, 79);
            this.clbOpcionais.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(150, 294);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(123, 40);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(293, 294);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(123, 40);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPortas.Location = new System.Drawing.Point(141, 203);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(238, 21);
            this.cbPortas.TabIndex = 9;
            // 
            // lbPortas
            // 
            this.lbPortas.AutoSize = true;
            this.lbPortas.Location = new System.Drawing.Point(21, 206);
            this.lbPortas.Name = "lbPortas";
            this.lbPortas.Size = new System.Drawing.Size(57, 13);
            this.lbPortas.TabIndex = 10;
            this.lbPortas.Text = "Qtd Portas";
            this.lbPortas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.clbOpcionais);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lbFabricante);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.tbModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbFabricante;
        private System.Windows.Forms.Label lbOpcionais;
        private System.Windows.Forms.CheckedListBox clbOpcionais;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lbPortas;
    }
}

