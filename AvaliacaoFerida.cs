using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjuryCare
{
    public partial class AvaliacaoFerida : UserControl
    {
        public AvaliacaoFerida()
        {
            InitializeComponent();
        }

        private void AvaliacaoFerida_Load(object sender, EventArgs e)
        {
            int raio = 30;
            GraphicsPath caminho = new GraphicsPath();

            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(lbAvaliacao.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(lbAvaliacao.Width - raio, lbAvaliacao.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, lbAvaliacao.Height - raio, raio, raio, 90, 90);
            caminho.CloseFigure();

            GraphicsPath borda = new GraphicsPath();

            borda.AddArc(0, 0, raio, raio, 180, 90);
            borda.AddArc(pnInfo.Width - raio, 0, raio, raio, 270, 90);
            borda.AddArc(pnInfo.Width - raio, pnInfo.Height - raio, raio, raio, 0, 90);
            borda.AddArc(0, pnInfo.Height - raio, raio, raio, 90, 90);
            borda.CloseFigure();

            lbAvaliacao.Region = new Region(caminho);
            pnInfo.Region = new Region(borda);
        }

        private void label1_Click(object sender, EventArgs e){}

        private void label1_Click_1(object sender, EventArgs e){}

        private void label2_Click(object sender, EventArgs e){}

        private void label13_Click(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}
    }
}
