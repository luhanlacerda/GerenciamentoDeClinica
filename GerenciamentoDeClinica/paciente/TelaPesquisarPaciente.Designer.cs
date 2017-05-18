﻿namespace GerenciamentoDeClinica.paciente
{
    partial class TelaPesquisarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarPaciente));
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovaBusca = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedPesqCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePesq = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.maskedCell = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.comboPais = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(379, 307);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 23;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(379, 278);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(379, 249);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovaBusca);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maskedPesqCPF);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomePesq);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro da Pesquisa";
            // 
            // btnNovaBusca
            // 
            this.btnNovaBusca.Location = new System.Drawing.Point(319, 35);
            this.btnNovaBusca.Name = "btnNovaBusca";
            this.btnNovaBusca.Size = new System.Drawing.Size(75, 23);
            this.btnNovaBusca.TabIndex = 3;
            this.btnNovaBusca.Text = "Nova Busca";
            this.btnNovaBusca.UseVisualStyleBackColor = true;
            this.btnNovaBusca.Click += new System.EventHandler(this.btnNovaBusca_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(238, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CPF:";
            // 
            // maskedPesqCPF
            // 
            this.maskedPesqCPF.Location = new System.Drawing.Point(51, 61);
            this.maskedPesqCPF.Mask = "000.000.000-00";
            this.maskedPesqCPF.Name = "maskedPesqCPF";
            this.maskedPesqCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedPesqCPF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // txtNomePesq
            // 
            this.txtNomePesq.Location = new System.Drawing.Point(50, 35);
            this.txtNomePesq.Name = "txtNomePesq";
            this.txtNomePesq.Size = new System.Drawing.Size(168, 20);
            this.txtNomePesq.TabIndex = 0;
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
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(128, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 9;
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
            // maskedCPF
            // 
            this.maskedCPF.Enabled = false;
            this.maskedCPF.Location = new System.Drawing.Point(10, 83);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(128, 83);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
            // 
            // maskedCell
            // 
            this.maskedCell.Enabled = false;
            this.maskedCell.Location = new System.Drawing.Point(246, 83);
            this.maskedCell.Mask = "(##) #.####-####";
            this.maskedCell.Name = "maskedCell";
            this.maskedCell.Size = new System.Drawing.Size(89, 20);
            this.maskedCell.TabIndex = 7;
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
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(125, 67);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 20;
            this.lblRG.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(10, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 4;
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
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(8, 120);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 53;
            this.lblDataNascimento.Text = "Data de Nascimento:";
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
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.groupBox1);
            this.GroupBox.Controls.Add(this.comboPais);
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
            this.GroupBox.Controls.Add(this.btnRemover);
            this.GroupBox.Controls.Add(this.btnEditar);
            this.GroupBox.Controls.Add(this.btnAtualizar);
            this.GroupBox.Controls.Add(this.lblDataNascimento);
            this.GroupBox.Controls.Add(this.lblNome);
            this.GroupBox.Controls.Add(this.txtNome);
            this.GroupBox.Controls.Add(this.lblRG);
            this.GroupBox.Controls.Add(this.lblCPF);
            this.GroupBox.Controls.Add(this.maskedCell);
            this.GroupBox.Controls.Add(this.txtRG);
            this.GroupBox.Controls.Add(this.maskedCPF);
            this.GroupBox.Controls.Add(this.lblContato);
            this.GroupBox.Controls.Add(this.txtEmail);
            this.GroupBox.Controls.Add(this.lblEmail);
            this.GroupBox.Location = new System.Drawing.Point(3, 109);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(464, 339);
            this.GroupBox.TabIndex = 44;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Editar Campos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSolteiro);
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Controls.Add(this.rbViuvo);
            this.groupBox1.Location = new System.Drawing.Point(11, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 48);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Enabled = false;
            this.rbSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbSolteiro.TabIndex = 10;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro(a)";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Enabled = false;
            this.rbCasado.Location = new System.Drawing.Point(129, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 17);
            this.rbCasado.TabIndex = 11;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado(a)";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Enabled = false;
            this.rbViuvo.Location = new System.Drawing.Point(254, 19);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbViuvo.TabIndex = 12;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // comboPais
            // 
            this.comboPais.Enabled = false;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(198, 310);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(136, 21);
            this.comboPais.TabIndex = 20;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(9, 310);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(117, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(140, 310);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 21);
            this.comboUF.TabIndex = 19;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(9, 271);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(101, 271);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(71, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(101, 229);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(236, 20);
            this.txtLogradouro.TabIndex = 14;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Enabled = false;
            this.maskedCEP.Location = new System.Drawing.Point(10, 229);
            this.maskedCEP.Mask = "#####-###";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(74, 20);
            this.maskedCEP.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(196, 294);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 94;
            this.lblPais.Text = "País:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(137, 294);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 93;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(7, 294);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 92;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(191, 252);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 91;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(99, 252);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 90;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 252);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 89;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(100, 213);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 88;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(7, 213);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 87;
            this.lblCEP.Text = "CEP;";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(194, 271);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(143, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // dateTimeDtNasc
            // 
            this.dateTimeDtNasc.Enabled = false;
            this.dateTimeDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDtNasc.Location = new System.Drawing.Point(12, 136);
            this.dateTimeDtNasc.Name = "dateTimeDtNasc";
            this.dateTimeDtNasc.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDtNasc.TabIndex = 8;
            // 
            // TelaPesquisarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox);
            this.Name = "TelaPesquisarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePesq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedPesqCPF;
        private System.Windows.Forms.Button btnNovaBusca;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox maskedCell;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dateTimeDtNasc;
        private System.Windows.Forms.ComboBox comboPais;
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
    }
}