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
    public partial class Referencias : UserControl
    {
        public Referencias()
        {
            InitializeComponent();
        }

        private void Referencias_Load(object sender, EventArgs e)
        {
            int raio = 30;
            GraphicsPath caminho = new GraphicsPath();

            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(pnTitulo.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(pnTitulo.Width - raio, pnTitulo.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, pnTitulo.Height - raio, raio, raio, 90, 90);
            caminho.CloseFigure();

            GraphicsPath borda = new GraphicsPath();

            borda.AddArc(0, 0, raio, raio, 180, 90);
            borda.AddArc(pnInfo.Width - raio, 0, raio, raio, 270, 90);
            borda.AddArc(pnInfo.Width - raio, pnInfo.Height - raio, raio, raio, 0, 90);
            borda.AddArc(0, pnInfo.Height - raio, raio, raio, 90, 90);
            borda.CloseFigure();

            pnTitulo.Region = new Region(caminho);
            pnInfo.Region = new Region(borda);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel7.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://gemini.google.com/app?hl=pt-BR",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel1.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.flaticon.com/br/icone-gratis/ferida_2025641 ",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel2.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://br.freepik.com/vetores-premium/pele-lesionada-das-maos-e-procedimentos-de-limpeza-de-feridas-primeiros-socorros-para-feridas-cura-ou-tratamento-de-medicamentos-primeira-ajuda-de-emergencia-para-traumas-de-maos-humanas_30622230.htm ",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel3.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://hospitalamigo.com.br",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel4.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.flaticon.com/br/icone-gratis/tratamento-de-feridas_17306911 ",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel5.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://pin.it/1ZbXuoclU",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Indica que o link foi visitado (muda a cor)
            linkLabel6.LinkVisited = true;

            // Abre o site no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://chatgpt.com",
                UseShellExecute = true // precisa disso em .NET 5+ ou .NET 6+
            });
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
