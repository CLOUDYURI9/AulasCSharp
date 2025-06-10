namespace WinFormsAppAula1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void lbTexto_Click(object sender, EventArgs e)
        {


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            chAtivo.Checked = true;
        }
    }
}
