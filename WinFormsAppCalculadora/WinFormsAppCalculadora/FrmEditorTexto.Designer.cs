namespace WinFormsAppCalculadora
{
    partial class FrmEditorTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnNegrito = new Button();
            lbEstilo = new Label();
            btnItalic = new Button();
            btnRegular = new Button();
            lbFontSize = new Label();
            btnPequeno = new Button();
            btnMedio = new Button();
            btnGrande = new Button();
            lbCor = new Label();
            btnAmarelo = new Button();
            btnVermelho = new Button();
            btnPreto = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(28, 31);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(728, 76);
            txtResultado.TabIndex = 0;
            // 
            // btnNegrito
            // 
            btnNegrito.Location = new Point(43, 141);
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(92, 51);
            btnNegrito.TabIndex = 1;
            btnNegrito.Text = "Negrito";
            btnNegrito.UseVisualStyleBackColor = true;
            btnNegrito.Click += btnNegrito_Click;
            // 
            // lbEstilo
            // 
            lbEstilo.AutoSize = true;
            lbEstilo.Location = new Point(51, 118);
            lbEstilo.Name = "lbEstilo";
            lbEstilo.Size = new Size(84, 15);
            lbEstilo.TabIndex = 2;
            lbEstilo.Text = "Estilo da Fonte";
            // 
            // btnItalic
            // 
            btnItalic.Location = new Point(43, 198);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(92, 51);
            btnItalic.TabIndex = 3;
            btnItalic.Text = "Italic";
            btnItalic.UseVisualStyleBackColor = true;
            btnItalic.Click += btnItalic_Click;
            // 
            // btnRegular
            // 
            btnRegular.Location = new Point(43, 255);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(92, 51);
            btnRegular.TabIndex = 4;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = true;
            btnRegular.Click += btnRegular_Click;
            // 
            // lbFontSize
            // 
            lbFontSize.AutoSize = true;
            lbFontSize.Location = new Point(164, 122);
            lbFontSize.Name = "lbFontSize";
            lbFontSize.Size = new Size(103, 15);
            lbFontSize.TabIndex = 5;
            lbFontSize.Text = "Tamanho da fonte";
            // 
            // btnPequeno
            // 
            btnPequeno.Location = new Point(164, 255);
            btnPequeno.Name = "btnPequeno";
            btnPequeno.Size = new Size(92, 51);
            btnPequeno.TabIndex = 6;
            btnPequeno.Text = "Pequeno";
            btnPequeno.UseVisualStyleBackColor = true;
            btnPequeno.Click += btnPequeno_Click;
            // 
            // btnMedio
            // 
            btnMedio.Location = new Point(164, 198);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(92, 51);
            btnMedio.TabIndex = 7;
            btnMedio.Text = "Medio";
            btnMedio.UseVisualStyleBackColor = true;
            btnMedio.Click += btnMedio_Click;
            // 
            // btnGrande
            // 
            btnGrande.Location = new Point(164, 140);
            btnGrande.Name = "btnGrande";
            btnGrande.Size = new Size(92, 51);
            btnGrande.TabIndex = 8;
            btnGrande.Text = "Grande";
            btnGrande.UseVisualStyleBackColor = true;
            btnGrande.Click += btnGrande_Click;
            // 
            // lbCor
            // 
            lbCor.AutoSize = true;
            lbCor.Location = new Point(302, 124);
            lbCor.Name = "lbCor";
            lbCor.Size = new Size(75, 15);
            lbCor.TabIndex = 9;
            lbCor.Text = "Cor da Fonte";
            // 
            // btnAmarelo
            // 
            btnAmarelo.Location = new Point(302, 257);
            btnAmarelo.Name = "btnAmarelo";
            btnAmarelo.Size = new Size(92, 51);
            btnAmarelo.TabIndex = 10;
            btnAmarelo.Text = "Amarelo";
            btnAmarelo.UseVisualStyleBackColor = true;
            btnAmarelo.Click += btnAmarelo_Click;
            // 
            // btnVermelho
            // 
            btnVermelho.Location = new Point(302, 200);
            btnVermelho.Name = "btnVermelho";
            btnVermelho.Size = new Size(92, 51);
            btnVermelho.TabIndex = 11;
            btnVermelho.Text = "Vermelho";
            btnVermelho.UseVisualStyleBackColor = true;
            btnVermelho.Click += btnVermelho_Click;
            // 
            // btnPreto
            // 
            btnPreto.Location = new Point(302, 140);
            btnPreto.Name = "btnPreto";
            btnPreto.Size = new Size(92, 51);
            btnPreto.TabIndex = 12;
            btnPreto.Text = "Preto";
            btnPreto.UseVisualStyleBackColor = true;
            btnPreto.Click += btnPreto_Click;
            // 
            // FrmEditorTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPreto);
            Controls.Add(btnVermelho);
            Controls.Add(btnAmarelo);
            Controls.Add(lbCor);
            Controls.Add(btnGrande);
            Controls.Add(btnMedio);
            Controls.Add(btnPequeno);
            Controls.Add(lbFontSize);
            Controls.Add(btnRegular);
            Controls.Add(btnItalic);
            Controls.Add(lbEstilo);
            Controls.Add(btnNegrito);
            Controls.Add(txtResultado);
            Name = "FrmEditorTexto";
            Text = "FrmEditorTexto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnNegrito;
        private Label lbEstilo;
        private Button btnItalic;
        private Button btnRegular;
        private Label lbFontSize;
        private Button btnPequeno;
        private Button btnMedio;
        private Button btnGrande;
        private Label lbCor;
        private Button btnAmarelo;
        private Button btnVermelho;
        private Button btnPreto;
    }
}