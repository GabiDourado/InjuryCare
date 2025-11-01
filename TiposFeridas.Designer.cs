namespace InjuryCare
{
    partial class TiposFeridas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposFeridas));
            this.Pan1 = new System.Windows.Forms.Panel();
            this.Pan2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pan1.SuspendLayout();
            this.Pan2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan1
            // 
            this.Pan1.BackColor = System.Drawing.Color.Aquamarine;
            this.Pan1.Controls.Add(this.label1);
            this.Pan1.Location = new System.Drawing.Point(14, 19);
            this.Pan1.Name = "Pan1";
            this.Pan1.Size = new System.Drawing.Size(1041, 66);
            this.Pan1.TabIndex = 0;
            this.Pan1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pan2
            // 
            this.Pan2.BackColor = System.Drawing.Color.Aquamarine;
            this.Pan2.Controls.Add(this.label6);
            this.Pan2.Controls.Add(this.label5);
            this.Pan2.Controls.Add(this.label4);
            this.Pan2.Controls.Add(this.label3);
            this.Pan2.Controls.Add(this.label2);
            this.Pan2.Location = new System.Drawing.Point(14, 104);
            this.Pan2.Name = "Pan2";
            this.Pan2.Size = new System.Drawing.Size(1041, 671);
            this.Pan2.TabIndex = 0;
            this.Pan2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de Feridas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "É importante classificar as feridas para entender sua origem e o tratamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pelo Agente Causal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(688, 216);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pelo Grau de Contaminação:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 168);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // TiposFeridas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan2);
            this.Controls.Add(this.Pan1);
            this.Name = "TiposFeridas";
            this.Size = new System.Drawing.Size(1431, 946);
            this.Load += new System.EventHandler(this.TiposFeridas_Load);
            this.Pan1.ResumeLayout(false);
            this.Pan1.PerformLayout();
            this.Pan2.ResumeLayout(false);
            this.Pan2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan1;
        private System.Windows.Forms.Panel Pan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
