namespace GerenciamentoDeClinica.telamedico
{
    partial class TelaPesquisarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarMedico));
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovaBusca = new System.Windows.Forms.Button();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesqNome = new System.Windows.Forms.Label();
            this.txtPesqCRM = new System.Windows.Forms.TextBox();
            this.lblPesqCRM = new System.Windows.Forms.Label();
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
            this.comboEspecialidade = new System.Windows.Forms.ComboBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.dateTimeDtNasc = new System.Windows.Forms.DateTimePicker();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.maskedCell = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.listMedicos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(383, 352);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(383, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(383, 294);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovaBusca);
            this.groupBox2.Controls.Add(this.txtPesqNome);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.lblPesqNome);
            this.groupBox2.Controls.Add(this.txtPesqCRM);
            this.groupBox2.Controls.Add(this.lblPesqCRM);
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro de pesquisa";
            // 
            // btnNovaBusca
            // 
            this.btnNovaBusca.Location = new System.Drawing.Point(270, 56);
            this.btnNovaBusca.Name = "btnNovaBusca";
            this.btnNovaBusca.Size = new System.Drawing.Size(75, 23);
            this.btnNovaBusca.TabIndex = 3;
            this.btnNovaBusca.Text = "Nova Busca";
            this.btnNovaBusca.UseVisualStyleBackColor = true;
            this.btnNovaBusca.Click += new System.EventHandler(this.btnNovaBusca_Click);
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Location = new System.Drawing.Point(53, 19);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(292, 20);
            this.txtPesqNome.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(190, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPesqNome
            // 
            this.lblPesqNome.AutoSize = true;
            this.lblPesqNome.Location = new System.Drawing.Point(9, 19);
            this.lblPesqNome.Name = "lblPesqNome";
            this.lblPesqNome.Size = new System.Drawing.Size(38, 13);
            this.lblPesqNome.TabIndex = 18;
            this.lblPesqNome.Text = "Nome:";
            // 
            // txtPesqCRM
            // 
            this.txtPesqCRM.Location = new System.Drawing.Point(53, 56);
            this.txtPesqCRM.Name = "txtPesqCRM";
            this.txtPesqCRM.Size = new System.Drawing.Size(100, 20);
            this.txtPesqCRM.TabIndex = 1;
            // 
            // lblPesqCRM
            // 
            this.lblPesqCRM.AutoSize = true;
            this.lblPesqCRM.Location = new System.Drawing.Point(13, 59);
            this.lblPesqCRM.Name = "lblPesqCRM";
            this.lblPesqCRM.Size = new System.Drawing.Size(34, 13);
            this.lblPesqCRM.TabIndex = 16;
            this.lblPesqCRM.Text = "CRM:";
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
            this.GroupBox.Controls.Add(this.comboEspecialidade);
            this.GroupBox.Controls.Add(this.lblEspecialidade);
            this.GroupBox.Controls.Add(this.btnRemover);
            this.GroupBox.Controls.Add(this.txtCRM);
            this.GroupBox.Controls.Add(this.btnEditar);
            this.GroupBox.Controls.Add(this.lblCRM);
            this.GroupBox.Controls.Add(this.btnAtualizar);
            this.GroupBox.Controls.Add(this.dateTimeDtNasc);
            this.GroupBox.Controls.Add(this.pictureUser);
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
            this.GroupBox.Location = new System.Drawing.Point(2, 129);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(465, 384);
            this.GroupBox.TabIndex = 45;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cadastrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSolteiro);
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Controls.Add(this.rbViuvo);
            this.groupBox1.Location = new System.Drawing.Point(9, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 48);
            this.groupBox1.TabIndex = 83;
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
            this.rbSolteiro.TabIndex = 12;
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
            this.rbCasado.TabIndex = 13;
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
            this.rbViuvo.TabIndex = 14;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // comboPais
            // 
            this.comboPais.Enabled = false;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(197, 355);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(136, 21);
            this.comboPais.TabIndex = 22;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(8, 355);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(117, 20);
            this.txtCidade.TabIndex = 20;
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(139, 355);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 21);
            this.comboUF.TabIndex = 21;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(8, 316);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(99, 316);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(71, 20);
            this.txtComplemento.TabIndex = 18;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(99, 274);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(236, 20);
            this.txtLogradouro.TabIndex = 16;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Enabled = false;
            this.maskedCEP.Location = new System.Drawing.Point(9, 274);
            this.maskedCEP.Mask = "#####-###";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(74, 20);
            this.maskedCEP.TabIndex = 15;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(195, 339);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 82;
            this.lblPais.Text = "País:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(136, 339);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 81;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 339);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 80;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(188, 297);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 79;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(96, 297);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 78;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(5, 297);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 77;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(98, 258);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 76;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 258);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 75;
            this.lblCEP.Text = "CEP;";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(191, 316);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(143, 20);
            this.txtBairro.TabIndex = 19;
            // 
            // comboEspecialidade
            // 
            this.comboEspecialidade.Enabled = false;
            this.comboEspecialidade.FormattingEnabled = true;
            this.comboEspecialidade.Location = new System.Drawing.Point(127, 136);
            this.comboEspecialidade.Name = "comboEspecialidade";
            this.comboEspecialidade.Size = new System.Drawing.Size(208, 21);
            this.comboEspecialidade.TabIndex = 9;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(124, 115);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(76, 13);
            this.lblEspecialidade.TabIndex = 66;
            this.lblEspecialidade.Text = "Especialidade:";
            // 
            // txtCRM
            // 
            this.txtCRM.Enabled = false;
            this.txtCRM.Location = new System.Drawing.Point(10, 136);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 8;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(7, 115);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 64;
            this.lblCRM.Text = "CRM:";
            // 
            // dateTimeDtNasc
            // 
            this.dateTimeDtNasc.Enabled = false;
            this.dateTimeDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDtNasc.Location = new System.Drawing.Point(8, 181);
            this.dateTimeDtNasc.Name = "dateTimeDtNasc";
            this.dateTimeDtNasc.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDtNasc.TabIndex = 10;
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
            this.lblDataNascimento.Location = new System.Drawing.Point(7, 165);
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
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(10, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 4;
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
            // maskedCell
            // 
            this.maskedCell.Enabled = false;
            this.maskedCell.Location = new System.Drawing.Point(246, 83);
            this.maskedCell.Mask = "(##) #.####-####";
            this.maskedCell.Name = "maskedCell";
            this.maskedCell.Size = new System.Drawing.Size(89, 20);
            this.maskedCell.TabIndex = 7;
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(128, 83);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
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
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(127, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(124, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "E-mail:";
            // 
            // listMedicos
            // 
            this.listMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.CRM});
            this.listMedicos.FullRowSelect = true;
            this.listMedicos.Location = new System.Drawing.Point(472, 9);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(214, 504);
            this.listMedicos.TabIndex = 46;
            this.listMedicos.UseCompatibleStateImageBehavior = false;
            this.listMedicos.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 115;
            // 
            // CRM
            // 
            this.CRM.Text = "CRM";
            // 
            // TelaPesquisarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 514);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "TelaPesquisarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médico";
            this.Load += new System.EventHandler(this.TelaPesquisarMedico_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesqCRM;
        private System.Windows.Forms.Label lblPesqCRM;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.Label lblPesqNome;
        private System.Windows.Forms.Button btnNovaBusca;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ComboBox comboEspecialidade;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.DateTimePicker dateTimeDtNasc;
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
        private System.Windows.Forms.ListView listMedicos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader CRM;
    }
}