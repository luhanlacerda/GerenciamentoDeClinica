namespace GerenciamentoDeClinica
{
    partial class TelaPesquisarSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarSecretaria));
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.dateTimeDtNasc = new System.Windows.Forms.DateTimePicker();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.comboPais = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovaBusca = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedPesqCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePesq = new System.Windows.Forms.TextBox();
            this.comboCidade = new System.Windows.Forms.ComboBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.comboCidade);
            this.GroupBox.Controls.Add(this.txtNome);
            this.GroupBox.Controls.Add(this.rbViuvo);
            this.GroupBox.Controls.Add(this.rbCasado);
            this.GroupBox.Controls.Add(this.rbSolteiro);
            this.GroupBox.Controls.Add(this.dateTimeDtNasc);
            this.GroupBox.Controls.Add(this.pictureUser);
            this.GroupBox.Controls.Add(this.btnRemover);
            this.GroupBox.Controls.Add(this.comboPais);
            this.GroupBox.Controls.Add(this.btnEditar);
            this.GroupBox.Controls.Add(this.btnAtualizar);
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
            this.GroupBox.Location = new System.Drawing.Point(2, 107);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(464, 398);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Editar Campos";
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(11, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Enabled = false;
            this.rbViuvo.Location = new System.Drawing.Point(164, 183);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbViuvo.TabIndex = 12;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            this.rbViuvo.CheckedChanged += new System.EventHandler(this.rbViuvo_CheckedChanged);
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Enabled = false;
            this.rbCasado.Location = new System.Drawing.Point(87, 183);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 17);
            this.rbCasado.TabIndex = 11;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado(a)";
            this.rbCasado.UseVisualStyleBackColor = true;
            this.rbCasado.CheckedChanged += new System.EventHandler(this.rbCasado_CheckedChanged);
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Enabled = false;
            this.rbSolteiro.Location = new System.Drawing.Point(9, 183);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbSolteiro.TabIndex = 10;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro(a)";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            this.rbSolteiro.CheckedChanged += new System.EventHandler(this.rbSolteiro_CheckedChanged);
            // 
            // dateTimeDtNasc
            // 
            this.dateTimeDtNasc.Enabled = false;
            this.dateTimeDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDtNasc.Location = new System.Drawing.Point(9, 136);
            this.dateTimeDtNasc.Name = "dateTimeDtNasc";
            this.dateTimeDtNasc.Size = new System.Drawing.Size(98, 20);
            this.dateTimeDtNasc.TabIndex = 8;
            this.dateTimeDtNasc.ValueChanged += new System.EventHandler(this.dateTimeDtNasc_ValueChanged);
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
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(373, 369);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // comboPais
            // 
            this.comboPais.Enabled = false;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(12, 365);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(136, 21);
            this.comboPais.TabIndex = 19;
            this.comboPais.SelectedIndexChanged += new System.EventHandler(this.comboPais_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(373, 340);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(373, 311);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // comboUF
            // 
            this.comboUF.Enabled = false;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(292, 365);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(47, 21);
            this.comboUF.TabIndex = 21;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(266, 314);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 20);
            this.txtNumero.TabIndex = 18;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(164, 314);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(71, 20);
            this.txtComplemento.TabIndex = 17;
            this.txtComplemento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(12, 314);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(136, 20);
            this.txtLogradouro.TabIndex = 16;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            // 
            // maskedCEP
            // 
            this.maskedCEP.Enabled = false;
            this.maskedCEP.Location = new System.Drawing.Point(236, 263);
            this.maskedCEP.Mask = "#####-###";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(100, 20);
            this.maskedCEP.TabIndex = 15;
            this.maskedCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCEP_MaskInputRejected);
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
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(9, 350);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 52;
            this.lblPais.Text = "País:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(289, 345);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 51;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(162, 350);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 50;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(8, 247);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 49;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(161, 295);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 47;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(263, 295);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 46;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(9, 295);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 45;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(233, 247);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 44;
            this.lblCEP.Text = "CEP;";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(11, 263);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(175, 20);
            this.txtBairro.TabIndex = 14;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
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
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 167);
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
            this.maskedCell.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCell_MaskInputRejected);
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(128, 83);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // maskedCPF
            // 
            this.maskedCPF.Enabled = false;
            this.maskedCPF.Location = new System.Drawing.Point(10, 83);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 5;
            this.maskedCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCPF_MaskInputRejected);
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
            this.txtEmail.Location = new System.Drawing.Point(128, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(8, 208);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço:";
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
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(11, 224);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(325, 20);
            this.txtEndereco.TabIndex = 13;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovaBusca);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maskedPesqCPF);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomePesq);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 107);
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
            // comboCidade
            // 
            this.comboCidade.Enabled = false;
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.Location = new System.Drawing.Point(165, 365);
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(121, 21);
            this.comboCidade.TabIndex = 20;
            // 
            // TelaPesquisarSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox);
            this.Name = "TelaPesquisarSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox comboPais;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovaBusca;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedPesqCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePesq;
        private System.Windows.Forms.DateTimePicker dateTimeDtNasc;
        private System.Windows.Forms.RadioButton rbViuvo;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboCidade;
    }
}