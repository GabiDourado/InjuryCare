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
    public partial class Inicio : UserControl
    {
        public event EventHandler BtnPeleClicado;
        public event EventHandler BtnLimpezaClicado;
        public event EventHandler BtnCurativoClicado;
        public event EventHandler BtncicatrizacaoClicado;
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
    }
}
