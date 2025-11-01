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
    public partial class TiposFeridas : UserControl
    {
        public TiposFeridas()
        {
            InitializeComponent();
        }

        private void TiposFeridas_Load(object sender, EventArgs e)
        {
            int raio = 30;

            GraphicsPath borda = new GraphicsPath();

            borda.AddArc(0, 0, raio, raio, 180, 90);
            borda.AddArc(Pan1.Width - raio, 0, raio, raio, 270, 90);
            borda.AddArc(Pan1.Width - raio, Pan1.Height - raio, raio, raio, 0, 90);
            borda.AddArc(0, Pan1.Height - raio, raio, raio, 90, 90);
            borda.CloseFigure();
            Pan1.Region = new Region(borda);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int raio = 30;

            GraphicsPath borda3 = new GraphicsPath();

            borda3.AddArc(0, 0, raio, raio, 180, 90);
            borda3.AddArc(Pan2.Width - raio, 0, raio, raio, 270, 90);
            borda3.AddArc(Pan2.Width - raio, Pan2.Height - raio, raio, raio, 0, 90);
            borda3.AddArc(0, Pan2.Height - raio, raio, raio, 90, 90);
            borda3.CloseFigure();
            Pan2.Region = new Region(borda3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
