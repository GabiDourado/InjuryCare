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
    public partial class Inicio : UserControl
    {
        public event EventHandler BtnPeleClicado;
        public event EventHandler BtnLimpezaClicado;
        public event EventHandler BtnCurativoClicado;
        public event EventHandler BtncicatrizacaoClicado;
        public event EventHandler BtnRefClicado;
        public event EventHandler BtnCreditoClicado;
        public event EventHandler BtnAvaliacaoFeridaClicado;
        public event EventHandler BtnTiposFeridasClicado;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnPele_Click(object sender, EventArgs e)
        {
            BtnPeleClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnLimpeza_Click(object sender, EventArgs e)
        {
            BtnLimpezaClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCurativos_Click(object sender, EventArgs e)
        {
            BtnCurativoClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCicatrizacao_Click(object sender, EventArgs e)
        {
            BtncicatrizacaoClicado?.Invoke(this, EventArgs.Empty);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            int raio = 30;
            GraphicsPath borda = new GraphicsPath();

            borda.AddArc(0, 0, raio, raio, 180, 90);
            borda.AddArc(btnPele.Width - raio, 0, raio, raio, 270, 90);
            borda.AddArc(btnPele.Width - raio, btnPele.Height - raio, raio, raio, 0, 90);
            borda.AddArc(0, btnPele.Height - raio, raio, raio, 90, 90);
            borda.CloseFigure();

            GraphicsPath borda1 = new GraphicsPath();

            borda1.AddArc(0, 0, raio, raio, 180, 90);
            borda1.AddArc(btnAvaliacao.Width - raio, 0, raio, raio, 270, 90);
            borda1.AddArc(btnAvaliacao.Width - raio, btnAvaliacao.Height - raio, raio, raio, 0, 90);
            borda1.AddArc(0, btnAvaliacao.Height - raio, raio, raio, 90, 90);
            borda1.CloseFigure();

            GraphicsPath borda2 = new GraphicsPath();

            borda2.AddArc(0, 0, raio, raio, 180, 90);
            borda2.AddArc(btnTipoFerida.Width - raio, 0, raio, raio, 270, 90);
            borda2.AddArc(btnTipoFerida.Width - raio, btnTipoFerida.Height - raio, raio, raio, 0, 90);
            borda2.AddArc(0, btnTipoFerida.Height - raio, raio, raio, 90, 90);
            borda2.CloseFigure();

            GraphicsPath borda3 = new GraphicsPath();

            borda3.AddArc(0, 0, raio, raio, 180, 90);
            borda3.AddArc(btnLimpeza.Width - raio, 0, raio, raio, 270, 90);
            borda3.AddArc(btnLimpeza.Width - raio, btnLimpeza.Height - raio, raio, raio, 0, 90);
            borda3.AddArc(0, btnLimpeza.Height - raio, raio, raio, 90, 90);
            borda3.CloseFigure();

            GraphicsPath borda4 = new GraphicsPath();

            borda4.AddArc(0, 0, raio, raio, 180, 90);
            borda4.AddArc(btnCurativos.Width - raio, 0, raio, raio, 270, 90);
            borda4.AddArc(btnCurativos.Width - raio, btnCurativos.Height - raio, raio, raio, 0, 90);
            borda4.AddArc(0, btnCurativos.Height - raio, raio, raio, 90, 90);
            borda4.CloseFigure();

            GraphicsPath borda5 = new GraphicsPath();

            borda5.AddArc(0, 0, raio, raio, 180, 90);
            borda5.AddArc(btnCicatrizacao.Width - raio, 0, raio, raio, 270, 90);
            borda5.AddArc(btnCicatrizacao.Width - raio, btnCicatrizacao.Height - raio, raio, raio, 0, 90);
            borda5.AddArc(0, btnCicatrizacao.Height - raio, raio, raio, 90, 90);
            borda5.CloseFigure();

            GraphicsPath borda6 = new GraphicsPath();

            borda6.AddArc(0, 0, raio, raio, 180, 90);
            borda6.AddArc(btnRef.Width - raio, 0, raio, raio, 270, 90);
            borda6.AddArc(btnRef.Width - raio, btnRef.Height - raio, raio, raio, 0, 90);
            borda6.AddArc(0, btnRef.Height - raio, raio, raio, 90, 90);
            borda6.CloseFigure();

            GraphicsPath borda7 = new GraphicsPath();

            borda7.AddArc(0, 0, raio, raio, 180, 90);
            borda7.AddArc(btnCredito.Width - raio, 0, raio, raio, 270, 90);
            borda7.AddArc(btnCredito.Width - raio, btnCredito.Height - raio, raio, raio, 0, 90);
            borda7.AddArc(0, btnCredito.Height - raio, raio, raio, 90, 90);
            borda7.CloseFigure();

            btnPele.Region = new Region(borda);
            btnAvaliacao.Region = new Region(borda1);
            btnTipoFerida.Region = new Region(borda2);
            btnLimpeza.Region = new Region(borda3);
            btnCurativos.Region = new Region(borda4);
            btnCicatrizacao.Region = new Region(borda5);
            btnRef.Region = new Region(borda6);
            btnCredito.Region = new Region(borda7);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            BtnRefClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            BtnCreditoClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            BtnAvaliacaoFeridaClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnTipoFerida_Click(object sender, EventArgs e)
        {
            BtnTiposFeridasClicado?.Invoke(this, EventArgs.Empty);
        }
    }
}
