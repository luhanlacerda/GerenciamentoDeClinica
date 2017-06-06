namespace GerenciamentoDeClinica.telasecretaria
{
    partial class TelaCadastrarSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarSecretaria));
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.dateTimeDtNasc = new System.Windows.Forms.DateTimePicker();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.maskedContato = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.txtPais);
            this.GroupBox.Controls.Add(this.groupBox1);
            this.GroupBox.Controls.Add(this.txtCidade);
            this.GroupBox.Controls.Add(this.comboUF);
            this.GroupBox.Controls.Add(this.txtNumero);
            this.GroupBox.Controls.Add(this.txtComplemento);
            this.GroupBox.Controls.Add(this.txtLogradouro);
            this.GroupBox.Controls.Add(this.maskedCEP);
            this.GroupBox.Controls.Add(this.lblPais);
            this.GroupBox.Controls.Add(this.lblUF);
            this.GroupBox.Controls.Add(this.lblCidade);
            this.GroupBox.Controls.Add(this.lblBairro);
            this.GroupBox.Controls.Add(this.lblComplemento);
            this.GroupBox.Controls.Add(this.lblNumero);
            this.GroupBox.Controls.Add(this.lblLogradouro);
            this.GroupBox.Controls.Add(this.lblCEP);
            this.GroupBox.Controls.Add(this.txtBairro);
            this.GroupBox.Controls.Add(this.dateTimeDtNasc);
            this.GroupBox.Controls.Add(this.pictureUser);
            this.GroupBox.Controls.Add(this.lblDataNascimento);
            this.GroupBox.Controls.Add(this.lblNome);
            this.GroupBox.Controls.Add(this.btnCadastrar);
            this.GroupBox.Controls.Add(this.txtNome);
            this.GroupBox.Controls.Add(this.lblRG);
            this.GroupBox.Controls.Add(this.lblCPF);
            this.GroupBox.Controls.Add(this.maskedContato);
            this.GroupBox.Controls.Add(this.txtRG);
            this.GroupBox.Controls.Add(this.maskedCPF);
            this.GroupBox.Controls.Add(this.lblContato);
            this.GroupBox.Controls.Add(this.txtEmail);
            this.GroupBox.Controls.Add(this.lblEmail);
            this.GroupBox.Location = new System.Drawing.Point(2, 1);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(470, 357);
            this.GroupBox.TabIndex = 44;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cadastrar";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(199, 325);
            this.txtPais.MaxLength = 30;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(134, 20);
            this.txtPais.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSolteiro);
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Controls.Add(this.rbViuvo);
            this.groupBox1.Location = new System.Drawing.Point(9, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 48);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbSolteiro.TabIndex = 6;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro(a)";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(129, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 17);
            this.rbCasado.TabIndex = 7;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado(a)";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Location = new System.Drawing.Point(254, 19);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbViuvo.TabIndex = 8;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(9, 326);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(117, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // comboUF
            // 
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(140, 326);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 21);
            this.comboUF.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(9, 277);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(99, 277);
            this.txtComplemento.MaxLength = 10;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(71, 20);
            this.txtComplemento.TabIndex = 12;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(99, 232);
            this.txtLogradouro.MaxLength = 50;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(236, 20);
            this.txtLogradouro.TabIndex = 10;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Location = new System.Drawing.Point(9, 232);
            this.maskedCEP.Mask = "#####-###";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(74, 20);
            this.maskedCEP.TabIndex = 9;
            this.maskedCEP.Leave += new System.EventHandler(this.maskedCEP_Leave);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(196, 310);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 94;
            this.lblPais.Text = "País:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(137, 310);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 93;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(7, 310);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 92;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(189, 258);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 91;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(96, 258);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 90;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 258);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 89;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(98, 216);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 88;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 216);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 87;
            this.lblCEP.Text = "CEP;";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(192, 277);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(143, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // dateTimeDtNasc
            // 
            this.dateTimeDtNasc.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDtNasc.Location = new System.Drawing.Point(12, 135);
            this.dateTimeDtNasc.Name = "dateTimeDtNasc";
            this.dateTimeDtNasc.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDtNasc.TabIndex = 4;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(358, 40);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(100, 116);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 62;
            this.pictureUser.TabStop = false;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(8, 120);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 53;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(383, 323);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 43);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(125, 67);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 20;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(11, 67);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF:";
            // 
            // maskedContato
            // 
            this.maskedContato.Location = new System.Drawing.Point(246, 83);
            this.maskedContato.Mask = "(##) #.####-####";
            this.maskedContato.Name = "maskedContato";
            this.maskedContato.Size = new System.Drawing.Size(89, 20);
            this.maskedContato.TabIndex = 3;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(128, 83);
            this.txtRG.MaxLength = 20;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 2;
            // 
            // maskedCPF
            // 
            this.maskedCPF.Location = new System.Drawing.Point(10, 83);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 1;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(244, 67);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(47, 13);
            this.lblContato.TabIndex = 22;
            this.lblContato.Text = "Contato:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 136);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(125, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "E-mail:";
            // 
            // TelaCadastrarSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 358);
            this.Controls.Add(this.GroupBox);
            this.Name = "TelaCadastrarSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastrarSecretaria_FormClosing);
            this.Load += new System.EventHandler(this.TelaCadastrarSecretaria_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox maskedContato;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dateTimeDtNasc;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox maskedCEP;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbViuvo;
        private System.Windows.Forms.TextBox txtPais;
    }
}