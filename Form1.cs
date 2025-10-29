using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjuryCare
{
    public partial class PgInicial : Form
    {

        public void MostrarTela(UserControl tela)
        {
            pnTelaInicial.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            pnTelaInicial.Controls.Add(tela);
        }
        public PgInicial()
        {
            InitializeComponent();
            MostrarTelaInicial();
        }
        private void MostrarTelaInicial()
        {
            var telaInicio = new Inicio();

            // Conecta o botão "Pele" para abrir a tela PeleFerida
            telaInicio.BtnPeleClicado += (s, e) =>
            {
                var telaPele = new PeleFerida();
                MostrarTela(telaPele);
            };
            // Conecta o botão "Limpeza" para abrir a tela LimpezaFerida
            telaInicio.BtnLimpezaClicado += (s, e) =>
            {
                var telaLimpeza = new LimpezaFerida();
                MostrarTela(telaLimpeza);
            };

            // Mostra a tela inicial no painel
            MostrarTela(telaInicio);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            MostrarTelaInicial();

        }
        private void pnTelaInicial_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
