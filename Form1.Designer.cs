namespace InjuryCare
{
    partial class PgInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgInicial));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnTelaInicial = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "top";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnTelaInicial
            // 
            this.pnTelaInicial.Location = new System.Drawing.Point(0, 116);
            this.pnTelaInicial.Name = "pnTelaInicial";
            this.pnTelaInicial.Size = new System.Drawing.Size(1431, 946);
            this.pnTelaInicial.TabIndex = 11;
            this.pnTelaInicial.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTelaInicial_Paint);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = global::InjuryCare.Properties.Resources.Logo_interna___injury_care;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogo.Location = new System.Drawing.Point(12, 17);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(384, 74);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1434, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PgInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 1055);
            this.Controls.Add(this.pnTelaInicial);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PgInicial";
            this.Text = "Injury Care";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Panel pnTelaInicial;
    }
}

