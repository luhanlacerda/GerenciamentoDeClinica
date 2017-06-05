namespace GerenciamentoDeClinica.telaconsulta
{
    partial class TelaCadastrarConsulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.listViewSecretarias = new System.Windows.Forms.ListView();
            this.SecretariaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecretariaCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIDSecretaria = new System.Windows.Forms.TextBox();
            this.lblSecretariaID = new System.Windows.Forms.Label();
            this.btnPesquisarSecretaria = new System.Windows.Forms.Button();
            this.txtNomeSecretaria = new System.Windows.Forms.TextBox();
            this.lblNomeSecretaria = new System.Windows.Forms.Label();
            this.lblSecretaria = new System.Windows.Forms.Label();
            this.txtIDMedico = new System.Windows.Forms.TextBox();
            this.lblMedicoID = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.lblPacienteID = new System.Windows.Forms.Label();
            this.btnPesquisarMedico = new System.Windows.Forms.Button();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.listViewMedicos = new System.Windows.Forms.ListView();
            this.medicoNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medicoCRM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medicoEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.labelMedico = new System.Windows.Forms.Label();
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.pacienteNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pacienteCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.labelNomePaciente = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.dateTimePickerDia = new System.Windows.Forms.DateTimePicker();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.listViewSecretarias);
            this.groupBox1.Controls.Add(this.txtIDSecretaria);
            this.groupBox1.Controls.Add(this.lblSecretariaID);
            this.groupBox1.Controls.Add(this.btnPesquisarSecretaria);
            this.groupBox1.Controls.Add(this.txtNomeSecretaria);
            this.groupBox1.Controls.Add(this.lblNomeSecretaria);
            this.groupBox1.Controls.Add(this.lblSecretaria);
            this.groupBox1.Controls.Add(this.txtIDMedico);
            this.groupBox1.Controls.Add(this.lblMedicoID);
            this.groupBox1.Controls.Add(this.txtIDPaciente);
            this.groupBox1.Controls.Add(this.lblPacienteID);
            this.groupBox1.Controls.Add(this.btnPesquisarMedico);
            this.groupBox1.Controls.Add(this.btnPesquisarPaciente);
            this.groupBox1.Controls.Add(this.listViewMedicos);
            this.groupBox1.Controls.Add(this.txtNomeMedico);
            this.groupBox1.Controls.Add(this.lblNomeMedico);
            this.groupBox1.Controls.Add(this.labelMedico);
            this.groupBox1.Controls.Add(this.listViewPacientes);
            this.groupBox1.Controls.Add(this.txtNomePaciente);
            this.groupBox1.Controls.Add(this.labelNomePaciente);
            this.groupBox1.Controls.Add(this.labelPaciente);
            this.groupBox1.Controls.Add(this.dateTimePickerDia);
            this.groupBox1.Controls.Add(this.txtDuracao);
            this.groupBox1.Controls.Add(this.lblDuracao);
            this.groupBox1.Controls.Add(this.labelDia);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Consulta";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(327, 477);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(93, 21);
            this.comboEstado.TabIndex = 28;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(278, 481);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado:";
            // 
            // listViewSecretarias
            // 
            this.listViewSecretarias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SecretariaNome,
            this.SecretariaCPF});
            this.listViewSecretarias.FullRowSelect = true;
            this.listViewSecretarias.Location = new System.Drawing.Point(26, 378);
            this.listViewSecretarias.Name = "listViewSecretarias";
            this.listViewSecretarias.Size = new System.Drawing.Size(394, 79);
            this.listViewSecretarias.TabIndex = 26;
            this.listViewSecretarias.UseCompatibleStateImageBehavior = false;
            this.listViewSecretarias.View = System.Windows.Forms.View.Details;
            this.listViewSecretarias.SelectedIndexChanged += new System.EventHandler(this.listViewSecretarias_SelectedIndexChanged);
            // 
            // SecretariaNome
            // 
            this.SecretariaNome.Text = "Nome";
            // 
            // SecretariaCPF
            // 
            this.SecretariaCPF.Text = "CPF";
            // 
            // txtIDSecretaria
            // 
            this.txtIDSecretaria.Enabled = false;
            this.txtIDSecretaria.Location = new System.Drawing.Point(384, 334);
            this.txtIDSecretaria.Name = "txtIDSecretaria";
            this.txtIDSecretaria.Size = new System.Drawing.Size(36, 20);
            this.txtIDSecretaria.TabIndex = 25;
            // 
            // lblSecretariaID
            // 
            this.lblSecretariaID.AutoSize = true;
            this.lblSecretariaID.Location = new System.Drawing.Point(312, 337);
            this.lblSecretariaID.Name = "lblSecretariaID";
            this.lblSecretariaID.Size = new System.Drawing.Size(72, 13);
            this.lblSecretariaID.TabIndex = 24;
            this.lblSecretariaID.Text = "ID Secretária:";
            // 
            // btnPesquisarSecretaria
            // 
            this.btnPesquisarSecretaria.Location = new System.Drawing.Point(217, 332);
            this.btnPesquisarSecretaria.Name = "btnPesquisarSecretaria";
            this.btnPesquisarSecretaria.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarSecretaria.TabIndex = 23;
            this.btnPesquisarSecretaria.Text = "Pesquisar";
            this.btnPesquisarSecretaria.UseVisualStyleBackColor = true;
            this.btnPesquisarSecretaria.Click += new System.EventHandler(this.btnPesquisarSecretaria_Click);
            // 
            // txtNomeSecretaria
            // 
            this.txtNomeSecretaria.Location = new System.Drawing.Point(68, 334);
            this.txtNomeSecretaria.Name = "txtNomeSecretaria";
            this.txtNomeSecretaria.Size = new System.Drawing.Size(124, 20);
            this.txtNomeSecretaria.TabIndex = 22;
            // 
            // lblNomeSecretaria
            // 
            this.lblNomeSecretaria.AutoSize = true;
            this.lblNomeSecretaria.Location = new System.Drawing.Point(26, 334);
            this.lblNomeSecretaria.Name = "lblNomeSecretaria";
            this.lblNomeSecretaria.Size = new System.Drawing.Size(38, 13);
            this.lblNomeSecretaria.TabIndex = 21;
            this.lblNomeSecretaria.Text = "Nome:";
            // 
            // lblSecretaria
            // 
            this.lblSecretaria.AutoSize = true;
            this.lblSecretaria.Location = new System.Drawing.Point(13, 298);
            this.lblSecretaria.Name = "lblSecretaria";
            this.lblSecretaria.Size = new System.Drawing.Size(55, 13);
            this.lblSecretaria.TabIndex = 20;
            this.lblSecretaria.Text = "Secretária";
            // 
            // txtIDMedico
            // 
            this.txtIDMedico.Enabled = false;
            this.txtIDMedico.Location = new System.Drawing.Point(384, 186);
            this.txtIDMedico.Name = "txtIDMedico";
            this.txtIDMedico.Size = new System.Drawing.Size(36, 20);
            this.txtIDMedico.TabIndex = 19;
            // 
            // lblMedicoID
            // 
            this.lblMedicoID.AutoSize = true;
            this.lblMedicoID.Location = new System.Drawing.Point(312, 189);
            this.lblMedicoID.Name = "lblMedicoID";
            this.lblMedicoID.Size = new System.Drawing.Size(59, 13);
            this.lblMedicoID.TabIndex = 18;
            this.lblMedicoID.Text = "ID Medico:";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Enabled = false;
            this.txtIDPaciente.Location = new System.Drawing.Point(384, 52);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(36, 20);
            this.txtIDPaciente.TabIndex = 17;
            // 
            // lblPacienteID
            // 
            this.lblPacienteID.AutoSize = true;
            this.lblPacienteID.Location = new System.Drawing.Point(312, 53);
            this.lblPacienteID.Name = "lblPacienteID";
            this.lblPacienteID.Size = new System.Drawing.Size(66, 13);
            this.lblPacienteID.TabIndex = 16;
            this.lblPacienteID.Text = "ID Paciente:";
            // 
            // btnPesquisarMedico
            // 
            this.btnPesquisarMedico.Location = new System.Drawing.Point(217, 183);
            this.btnPesquisarMedico.Name = "btnPesquisarMedico";
            this.btnPesquisarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarMedico.TabIndex = 15;
            this.btnPesquisarMedico.Text = "Pesquisar";
            this.btnPesquisarMedico.UseVisualStyleBackColor = true;
            this.btnPesquisarMedico.Click += new System.EventHandler(this.btnPesquisarMedico_Click);
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(217, 50);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPaciente.TabIndex = 14;
            this.btnPesquisarPaciente.Text = "Pesquisar";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // listViewMedicos
            // 
            this.listViewMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicoNome,
            this.medicoCRM,
            this.medicoEspecialidade});
            this.listViewMedicos.FullRowSelect = true;
            this.listViewMedicos.Location = new System.Drawing.Point(26, 212);
            this.listViewMedicos.Name = "listViewMedicos";
            this.listViewMedicos.Size = new System.Drawing.Size(395, 83);
            this.listViewMedicos.TabIndex = 13;
            this.listViewMedicos.UseCompatibleStateImageBehavior = false;
            this.listViewMedicos.View = System.Windows.Forms.View.Details;
            this.listViewMedicos.SelectedIndexChanged += new System.EventHandler(this.listViewMedicos_SelectedIndexChanged);
            // 
            // medicoNome
            // 
            this.medicoNome.Text = "Nome";
            // 
            // medicoCRM
            // 
            this.medicoCRM.Text = "CRM";
            // 
            // medicoEspecialidade
            // 
            this.medicoEspecialidade.Text = "Especialidade";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(68, 186);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(124, 20);
            this.txtNomeMedico.TabIndex = 12;
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(23, 189);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(38, 13);
            this.lblNomeMedico.TabIndex = 11;
            this.lblNomeMedico.Text = "Nome:";
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.Location = new System.Drawing.Point(13, 159);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(42, 13);
            this.labelMedico.TabIndex = 10;
            this.labelMedico.Text = "Médico";
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pacienteNome,
            this.pacienteCPF});
            this.listViewPacientes.FullRowSelect = true;
            this.listViewPacientes.Location = new System.Drawing.Point(26, 79);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(395, 77);
            this.listViewPacientes.TabIndex = 9;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            this.listViewPacientes.View = System.Windows.Forms.View.Details;
            this.listViewPacientes.SelectedIndexChanged += new System.EventHandler(this.listViewPacientes_SelectedIndexChanged);
            // 
            // pacienteNome
            // 
            this.pacienteNome.Text = "Nome";
            // 
            // pacienteCPF
            // 
            this.pacienteCPF.Text = "CPF";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(68, 53);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(124, 20);
            this.txtNomePaciente.TabIndex = 8;
            // 
            // labelNomePaciente
            // 
            this.labelNomePaciente.AutoSize = true;
            this.labelNomePaciente.Location = new System.Drawing.Point(23, 53);
            this.labelNomePaciente.Name = "labelNomePaciente";
            this.labelNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.labelNomePaciente.TabIndex = 7;
            this.labelNomePaciente.Text = "Nome:";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(6, 26);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(49, 13);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(40, 478);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerDia.TabIndex = 1;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(201, 478);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(62, 20);
            this.txtDuracao.TabIndex = 2;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(144, 481);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(51, 13);
            this.lblDuracao.TabIndex = 4;
            this.lblDuracao.Text = "Duração:";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(7, 484);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(26, 13);
            this.labelDia.TabIndex = 1;
            this.labelDia.Text = "Dia:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(346, 540);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaCadastrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCadastrarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.TelaCadastrarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDia;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label labelMedico;
        private System.Windows.Forms.ListView listViewPacientes;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label labelNomePaciente;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.ListView listViewMedicos;
        private System.Windows.Forms.Button btnPesquisarMedico;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.ColumnHeader pacienteNome;
        private System.Windows.Forms.ColumnHeader pacienteCPF;
        private System.Windows.Forms.ColumnHeader medicoNome;
        private System.Windows.Forms.ColumnHeader medicoCRM;
        private System.Windows.Forms.ColumnHeader medicoEspecialidade;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label lblPacienteID;
        private System.Windows.Forms.TextBox txtIDMedico;
        private System.Windows.Forms.Label lblMedicoID;
        private System.Windows.Forms.Label lblNomeSecretaria;
        private System.Windows.Forms.Label lblSecretaria;
        private System.Windows.Forms.TextBox txtIDSecretaria;
        private System.Windows.Forms.Label lblSecretariaID;
        private System.Windows.Forms.Button btnPesquisarSecretaria;
        private System.Windows.Forms.TextBox txtNomeSecretaria;
        private System.Windows.Forms.ListView listViewSecretarias;
        private System.Windows.Forms.ColumnHeader SecretariaNome;
        private System.Windows.Forms.ColumnHeader SecretariaCPF;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}