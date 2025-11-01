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
    public partial class Cicatrizacao : UserControl
    {
        public Cicatrizacao()
        {
            InitializeComponent();
        }

        private void Cicatrizacao_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int raio = 30;

            GraphicsPath borda2 = new GraphicsPath();

            borda2.AddArc(0, 0, raio, raio, 180, 90);
            borda2.AddArc(Pan2.Width - raio, 0, raio, raio, 270, 90);
            borda2.AddArc(Pan2.Width - raio, Pan2.Height - raio, raio, raio, 0, 90);
            borda2.AddArc(0, Pan2.Height - raio, raio, raio, 90, 90);
            borda2.CloseFigure();
            Pan2.Region = new Region(borda2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChamarFuncaoDoForm();
        }
        private void ChamarFuncaoDoForm()
        {
            // Busca o form pai e converte para o tipo certo
            PgInicial form = this.FindForm() as PgInicial;

            if (form != null)
            {
                form.MostrarTelaInicial();
            }
        }
    }
}
