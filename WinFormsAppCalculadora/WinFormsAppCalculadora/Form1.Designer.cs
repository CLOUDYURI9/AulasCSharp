namespace WinFormsAppCalculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicacao = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnLimpar = new Button();
            btnSubtracao = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDivisao = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnResultado = new Button();
            btnSoma = new Button();
            btnVirgula = new Button();
            label1 = new Label();
            lbResultado = new Label();
            btnEditor = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(12, 55);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(280, 50);
            txtResultado.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.BackColor = Color.RoyalBlue;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(13, 176);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 40);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.RoyalBlue;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Location = new Point(89, 176);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 40);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.RoyalBlue;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(161, 176);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 40);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.MediumSeaGreen;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.ForeColor = SystemColors.ControlLightLight;
            btnMultiplicacao.Location = new Point(234, 222);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(67, 40);
            btnMultiplicacao.TabIndex = 4;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.RoyalBlue;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(159, 274);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 40);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.RoyalBlue;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Location = new Point(89, 320);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 40);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.MediumSeaGreen;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(13, 320);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(67, 40);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.MediumSeaGreen;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(233, 274);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(67, 40);
            btnSubtracao.TabIndex = 8;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.RoyalBlue;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(86, 274);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 40);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.RoyalBlue;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(13, 274);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 40);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.MediumSeaGreen;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(234, 176);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(67, 40);
            btnDivisao.TabIndex = 11;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.RoyalBlue;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(161, 222);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 40);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.RoyalBlue;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(89, 222);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 40);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.RoyalBlue;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(13, 222);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 40);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.CadetBlue;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.ForeColor = Color.White;
            btnResultado.Location = new Point(233, 131);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(67, 40);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.MediumSeaGreen;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(233, 320);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(67, 40);
            btnSoma.TabIndex = 16;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.MediumSeaGreen;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(161, 320);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(67, 40);
            btnVirgula.TabIndex = 17;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 131);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 18;
            label1.Text = "Calculadora";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(17, 393);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(16, 15);
            lbResultado.TabIndex = 19;
            lbResultado.Text = "...";
            // 
            // btnEditor
            // 
            btnEditor.Location = new Point(217, 393);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new Size(75, 23);
            btnEditor.TabIndex = 20;
            btnEditor.Text = "Editor";
            btnEditor.UseVisualStyleBackColor = true;
            btnEditor.Click += btnEditor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(304, 441);
            Controls.Add(btnEditor);
            Controls.Add(lbResultado);
            Controls.Add(label1);
            Controls.Add(btnVirgula);
            Controls.Add(btnSoma);
            Controls.Add(btnResultado);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnDivisao);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btnSubtracao);
            Controls.Add(btnLimpar);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacao;
        private Button btn3;
        private Button btn0;
        private Button btnLimpar;
        private Button btnSubtracao;
        private Button btn2;
        private Button btn1;
        private Button btnDivisao;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnResultado;
        private Button btnSoma;
        private Button btnVirgula;
        private Label label1;
        private Label lbResultado;
        private Button btnEditor;
    }
}
