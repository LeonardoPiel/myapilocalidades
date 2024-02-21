namespace MyApiLocalidades
{
    partial class frmInicio
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
            txtUF = new TextBox();
            lblUF = new Label();
            rtxtCodigo = new RichTextBox();
            lblSql = new Label();
            btnGerar = new Button();
            txtCodUF = new TextBox();
            lblCodUF = new Label();
            lblErro = new Label();
            btnSelectAll = new Button();
            lblCopiado = new Label();
            SuspendLayout();
            // 
            // txtUF
            // 
            txtUF.Location = new Point(508, 73);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(200, 39);
            txtUF.TabIndex = 0;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(231, 76);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(137, 32);
            lblUF.TabIndex = 1;
            lblUF.Text = "Digite a UF:";
            // 
            // rtxtCodigo
            // 
            rtxtCodigo.Location = new Point(231, 332);
            rtxtCodigo.Name = "rtxtCodigo";
            rtxtCodigo.Size = new Size(1235, 509);
            rtxtCodigo.TabIndex = 2;
            rtxtCodigo.Text = "";
            // 
            // lblSql
            // 
            lblSql.AutoSize = true;
            lblSql.Location = new Point(231, 277);
            lblSql.Name = "lblSql";
            lblSql.Size = new Size(61, 32);
            lblSql.TabIndex = 3;
            lblSql.Text = "SQL:";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(231, 199);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(158, 55);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // txtCodUF
            // 
            txtCodUF.Location = new Point(508, 137);
            txtCodUF.Name = "txtCodUF";
            txtCodUF.Size = new Size(200, 39);
            txtCodUF.TabIndex = 1;
            // 
            // lblCodUF
            // 
            lblCodUF.AutoSize = true;
            lblCodUF.Location = new Point(231, 137);
            lblCodUF.Name = "lblCodUF";
            lblCodUF.Size = new Size(271, 32);
            lblCodUF.TabIndex = 6;
            lblCodUF.Text = "Código UF para a query:";
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(1098, 80);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 32);
            lblErro.TabIndex = 7;
            lblErro.Click += label1_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(1240, 270);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(226, 46);
            btnSelectAll.TabIndex = 3;
            btnSelectAll.Text = "Selecionar Tudo";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // lblCopiado
            // 
            lblCopiado.AutoSize = true;
            lblCopiado.Location = new Point(1492, 284);
            lblCopiado.Name = "lblCopiado";
            lblCopiado.Size = new Size(0, 32);
            lblCopiado.TabIndex = 9;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 882);
            Controls.Add(lblCopiado);
            Controls.Add(btnSelectAll);
            Controls.Add(lblErro);
            Controls.Add(lblCodUF);
            Controls.Add(txtCodUF);
            Controls.Add(btnGerar);
            Controls.Add(lblSql);
            Controls.Add(rtxtCodigo);
            Controls.Add(lblUF);
            Controls.Add(txtUF);
            Name = "frmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUF;
        private Label lblUF;
        private RichTextBox rtxtCodigo;
        private Label lblSql;
        private Button btnGerar;
        private TextBox txtCodUF;
        private Label lblCodUF;
        private Label lblErro;
        private Button btnSelectAll;
        private Label lblCopiado;
    }
}
