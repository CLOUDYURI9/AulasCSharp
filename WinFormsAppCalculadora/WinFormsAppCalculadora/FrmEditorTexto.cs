using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCalculadora
{
    public partial class FrmEditorTexto : Form
    {
        public FrmEditorTexto()
        {
            InitializeComponent();
        }


        private void btnNegrito_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font, FontStyle.Italic);
        }


        private void btnRegular_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font.FontFamily, txtResultado.Font.Size, FontStyle.Regular);
        }


        private void btnGrande_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font.FontFamily, 20, txtResultado.Font.Style);
        }


        private void btnMedio_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font.FontFamily, 14, txtResultado.Font.Style);
        }


        private void btnPequeno_Click(object sender, EventArgs e)
        {
            txtResultado.Font = new Font(txtResultado.Font.FontFamily, 8, txtResultado.Font.Style);
        }


        private void btnPreto_Click(object sender, EventArgs e)
        {
            txtResultado.ForeColor = Color.Black;
        }


        private void btnVermelho_Click(object sender, EventArgs e)
        {
            txtResultado.ForeColor = Color.Red;
        }


        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            txtResultado.ForeColor = Color.Gold; // ou Color.Yellow
        }

    }
}
