namespace WinFormsAppCalculadora
{
    public partial class Form1 : Form
    {
        private double valor1 = 0, valor2 = 0;
        private string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void MetodoBotoes(Button sender)
        {
            var botao = (Button)sender;
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += botao.Text;

            lbResultado.Text += botao.Text;
        }

        private void MetodoSinais(Button sender)
        {
            if (txtResultado.Text == "0")
                return;

            var botao = (Button)sender;
            valor1 = double.Parse(txtResultado.Text);
            operacao = botao.Text;
            txtResultado.Clear();

            lbResultado.Text += botao.Text;

        }





        #region Botoes 
        private void btn1_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);

        }

        #endregion 


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            valor1 = valor2 = 0;
            operacao = "";

            lbResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            MetodoSinais((Button)sender);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            MetodoSinais((Button)sender);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            MetodoSinais((Button)sender);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            MetodoSinais((Button)sender);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtResultado.Text);
            switch (operacao)

            {
                case "+":
                    txtResultado.Text = (valor1 + valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "-":
                    txtResultado.Text = (valor1 - valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "X":
                    txtResultado.Text = (valor1 * valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "/":
                    txtResultado.Text = valor2 != 0 ? (valor1 / valor2).ToString() : "Erro";
                    lbResultado.Text = txtResultado.Text;
                    break;


            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            FrmEditorTexto frmEditorTexto = new FrmEditorTexto();
            frmEditorTexto.ShowDialog();
        }
    }
}


