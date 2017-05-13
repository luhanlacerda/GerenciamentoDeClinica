namespace GerenciamentoDeClinica
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
            this.comboEspecialidade = new System.Windows.Forms.ComboBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.dateTimeDtNasc = new System.Windows.Forms.DateTimePicker();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.comboPais = new System.Windows.Forms.ComboBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.maskedCell = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.comboCidade = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(376, 390);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 26;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(376, 361);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(376, 332);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 24;
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
            this.groupBox2.Size = new System.Drawing.Size(465, 120);
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
            this.GroupBox.Controls.Add(this.comboCidade);
            this.GroupBox.Controls.Add(this.comboEspecialidade);
            this.GroupBox.Controls.Add(this.lblEspecialidade);
            this.GroupBox.Controls.Add(this.btnRemover);
            this.GroupBox.Controls.Add(this.txtCRM);
            this.GroupBox.Controls.Add(this.btnEditar);
            this.GroupBox.Controls.Add(this.lblCRM);
            this.GroupBox.Controls.Add(this.btnAtualizar);
            this.GroupBox.Controls.Add(this.dateTimeDtNasc);
            this.GroupBox.Controls.Add(this.rbViuvo);
            this.GroupBox.Controls.Add(this.rbCasado);
            this.GroupBox.Controls.Add(this.rbSolteiro);
            this.GroupBox.Controls.Add(this.pictureUser);
            this.GroupBox.Controls.Add(this.comboPais);
            this.GroupBox.Controls.Add(this.comboUF);
            this.GroupBox.Controls.Add(this.txtNumero);
            this.GroupBox.Controls.Add(this.txtComplemento);
            this.GroupBox.Controls.Add(this.txtLogradouro);
            this.GroupBox.Controls.Add(this.maskedCEP);
            this.GroupBox.Controls.Add(this.lblDataNascimento);
            this.GroupBox.Controls.Add(this.lblPais);
            this.GroupBox.Controls.Add(this.lblUF);
            this.GroupBox.Controls.Add(this.lblCidade);
            this.GroupBox.Controls.Add(this.lblBairro);
            this.GroupBox.Controls.Add(this.lblComplemento);
            this.GroupBox.Controls.Add(this.lblNumero);
            this.GroupBox.Controls.Add(this.lblLogradouro);
            this.GroupBox.Controls.Add(this.lblCEP);
            this.GroupBox.Controls.Add(this.txtBairro);
            this.GroupBox.Controls.Add(this.lblNome);
            this.GroupBox.Controls.Add(this.txtNome);
            this.GroupBox.Controls.Add(this.lblRG);
            this.GroupBox.Controls.Add(this.lblEstadoCivil);
            this.GroupBox.Controls.Add(this.lblCPF);
            this.GroupBox.Controls.Add(this.maskedCell);
            this.GroupBox.Controls.Add(this.txtRG);
            this.GroupBox.Controls.Add(this.maskedCPF);
            this.GroupBox.Controls.Add(this.lblContato);
            this.GroupBox.Controls.Add(this.txtEmail);
            this.GroupBox.Controls.Add(this.lblEndereco);
            this.GroupBox.Controls.Add(this.lblEmail);
            this.GroupBox.Controls.Add(this.txtEndereco);
            this.GroupBox.Location = new System.Drawing.Point(2, 129);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(465, 429);
            this.GroupBox.TabIndex = 45;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cadastrar";
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
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Enabled = false;
            this.rbViuvo.Location = new System.Drawing.Point(172, 230);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbViuvo.TabIndex = 14;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Enabled = false;
            this.rbCasado.Location = new System.Drawing.Point(88, 230);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 17);
            this.rbCasado.TabIndex = 13;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado(a)";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Enabled = false;
            this.rbSolteiro.Location = new System.Drawing.Point(8, 230);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbSolteiro.TabIndex = 12;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro(a)";
            this.rbSolteiro.UseVisualStyleBackColor = true;
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
            // comboPais
            // 
            this.comboPais.Enabled = false;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(8, 398);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(136, 21);
            this.comboPais.TabIndex = 21;
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(291, 398);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(44, 21);
            this.comboUF.TabIndex = 23;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(266, 359);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 20);
            this.txtNumero.TabIndex = 20;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(164, 359);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(71, 20);
            this.txtComplemento.TabIndex = 19;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(9, 359);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(136, 20);
            this.txtLogradouro.TabIndex = 18;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Enabled = false;
            this.maskedCEP.Location = new System.Drawing.Point(235, 308);
            this.maskedCEP.Mask = "#####-###";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(100, 20);
            this.maskedCEP.TabIndex = 17;
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
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 382);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 52;
            this.lblPais.Text = "País:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(288, 382);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 51;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(161, 383);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 50;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 292);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 49;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(161, 340);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 47;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(263, 340);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 46;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(9, 340);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 45;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(232, 292);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 44;
            this.lblCEP.Text = "CEP;";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(10, 308);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(175, 20);
            this.txtBairro.TabIndex = 16;
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
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 214);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 42;
            this.lblEstadoCivil.Text = "Estado Civil:";
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
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(7, 253);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço:";
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
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(10, 269);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(325, 20);
            this.txtEndereco.TabIndex = 15;
            // 
            // comboCidade
            // 
            this.comboCidade.Enabled = false;
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.Location = new System.Drawing.Point(164, 398);
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(121, 21);
            this.comboCidade.TabIndex = 22;
            // 
            // TelaPesquisarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 561);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "TelaPesquisarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médico";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbViuvo;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.ComboBox comboPais;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox maskedCEP;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox maskedCell;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox comboCidade;
    }
}