namespace WinFormsAppAula1
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMensagem = new Button();
            txtResultado = new TextBox();
            txtTexto = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            lbResultado = new Label();
            lbTexto = new Label();
            cbTimes = new ComboBox();
            rbMaculino = new RadioButton();
            rbFeminino = new RadioButton();
            txtSenha = new TextBox();
            lbSenha = new Label();
            chAtivo = new CheckBox();
            SuspendLayout();
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(718, 415);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(70, 23);
            btnMensagem.TabIndex = 0;
            btnMensagem.Text = "Menssage";
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(60, 27);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(180, 23);
            txtResultado.TabIndex = 2;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(60, 110);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(180, 185);
            txtTexto.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Location = new Point(60, 312);
            btn1.Name = "btn1";
            btn1.Size = new Size(81, 23);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button2_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(147, 312);
            btn2.Name = "btn2";
            btn2.Size = new Size(76, 23);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(60, 9);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 6;
            lbResultado.Text = "Resultado";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(66, 80);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(35, 15);
            lbTexto.TabIndex = 7;
            lbTexto.Text = "Texto";
            lbTexto.Click += lbTexto_Click;
            // 
            // cbTimes
            // 
            cbTimes.FormattingEnabled = true;
            cbTimes.Items.AddRange(new object[] { "Palmeiras", "Santos", "São Paulo", "Corinthians" });
            cbTimes.Location = new Point(377, 27);
            cbTimes.Name = "cbTimes";
            cbTimes.Size = new Size(121, 23);
            cbTimes.TabIndex = 8;
            // 
            // rbMaculino
            // 
            rbMaculino.AutoSize = true;
            rbMaculino.Location = new Point(258, 155);
            rbMaculino.Name = "rbMaculino";
            rbMaculino.Size = new Size(80, 19);
            rbMaculino.TabIndex = 9;
            rbMaculino.TabStop = true;
            rbMaculino.Text = "Masculino";
            rbMaculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(258, 183);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 10;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(258, 27);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 11;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(258, 3);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 12;
            lbSenha.Text = "Senha";
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Location = new Point(377, 155);
            chAtivo.Name = "chAtivo";
            chAtivo.Size = new Size(54, 19);
            chAtivo.TabIndex = 13;
            chAtivo.Text = "Ativo";
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(chAtivo);
            Controls.Add(lbSenha);
            Controls.Add(txtSenha);
            Controls.Add(rbFeminino);
            Controls.Add(rbMaculino);
            Controls.Add(cbTimes);
            Controls.Add(lbTexto);
            Controls.Add(lbResultado);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTexto);
            Controls.Add(txtResultado);
            Controls.Add(btnMensagem);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMensagem;
        private TextBox txtResultado;
        private TextBox txtTexto;
        private Button btn1;
        private Button btn2;
        private Label lbResultado;
        private Label lbTexto;
        private ComboBox cbTimes;
        private RadioButton rbMaculino;
        private RadioButton rbFeminino;
        private TextBox txtSenha;
        private Label lbSenha;
        private CheckBox chAtivo;
    }
}
