namespace GerenciamentoDeClinica.telaconsulta
{
    partial class TelaPesquisarConsulta
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
            this.listViewConsultas = new System.Windows.Forms.ListView();
            this.IDConsulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Horario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesqPacienteID = new System.Windows.Forms.TextBox();
            this.txtPesqMedicoID = new System.Windows.Forms.TextBox();
            this.lblPesqMedID = new System.Windows.Forms.Label();
            this.lblPesqPacienteID = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewConsultas);
            this.groupBox1.Controls.Add(this.txtPesqPacienteID);
            this.groupBox1.Controls.Add(this.txtPesqMedicoID);
            this.groupBox1.Controls.Add(this.lblPesqMedID);
            this.groupBox1.Controls.Add(this.lblPesqPacienteID);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro da Pesquisa";
            // 
            // listViewConsultas
            // 
            this.listViewConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDConsulta,
            this.Paciente,
            this.Medico,
            this.Horario});
            this.listViewConsultas.Location = new System.Drawing.Point(15, 69);
            this.listViewConsultas.Name = "listViewConsultas";
            this.listViewConsultas.Size = new System.Drawing.Size(394, 97);
            this.listViewConsultas.TabIndex = 29;
            this.listViewConsultas.UseCompatibleStateImageBehavior = false;
            this.listViewConsultas.View = System.Windows.Forms.View.Details;
            this.listViewConsultas.SelectedIndexChanged += new System.EventHandler(this.listViewConsultas_SelectedIndexChanged);
            // 
            // IDConsulta
            // 
            this.IDConsulta.Text = "ID";
            // 
            // Paciente
            // 
            this.Paciente.Text = "Paciente";
            // 
            // Medico
            // 
            this.Medico.Text = "Médico";
            // 
            // Horario
            // 
            this.Horario.Text = "Horario";
            // 
            // txtPesqPacienteID
            // 
            this.txtPesqPacienteID.Location = new System.Drawing.Point(229, 24);
            this.txtPesqPacienteID.Name = "txtPesqPacienteID";
            this.txtPesqPacienteID.Size = new System.Drawing.Size(66, 20);
            this.txtPesqPacienteID.TabIndex = 28;
            // 
            // txtPesqMedicoID
            // 
            this.txtPesqMedicoID.Location = new System.Drawing.Point(77, 24);
            this.txtPesqMedicoID.Name = "txtPesqMedicoID";
            this.txtPesqMedicoID.Size = new System.Drawing.Size(66, 20);
            this.txtPesqMedicoID.TabIndex = 0;
            // 
            // lblPesqMedID
            // 
            this.lblPesqMedID.AutoSize = true;
            this.lblPesqMedID.Location = new System.Drawing.Point(12, 27);
            this.lblPesqMedID.Name = "lblPesqMedID";
            this.lblPesqMedID.Size = new System.Drawing.Size(59, 13);
            this.lblPesqMedID.TabIndex = 27;
            this.lblPesqMedID.Text = "ID Medico:";
            // 
            // lblPesqPacienteID
            // 
            this.lblPesqPacienteID.AutoSize = true;
            this.lblPesqPacienteID.Location = new System.Drawing.Point(157, 27);
            this.lblPesqPacienteID.Name = "lblPesqPacienteID";
            this.lblPesqPacienteID.Size = new System.Drawing.Size(66, 13);
            this.lblPesqPacienteID.TabIndex = 25;
            this.lblPesqPacienteID.Text = "ID Paciente:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(334, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.comboEstado);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.txtObservacoes);
            this.groupBox2.Controls.Add(this.txtReceita);
            this.groupBox2.Controls.Add(this.lblObservacao);
            this.groupBox2.Controls.Add(this.lblReceita);
            this.groupBox2.Location = new System.Drawing.Point(0, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Campos";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(441, 292);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(441, 247);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Enabled = false;
            this.txtObservacoes.Location = new System.Drawing.Point(6, 38);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(403, 79);
            this.txtObservacoes.TabIndex = 5;
            // 
            // txtReceita
            // 
            this.txtReceita.Enabled = false;
            this.txtReceita.Location = new System.Drawing.Point(6, 155);
            this.txtReceita.Multiline = true;
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(403, 79);
            this.txtReceita.TabIndex = 6;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(3, 22);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(73, 13);
            this.lblObservacao.TabIndex = 10;
            this.lblObservacao.Text = "Observações:";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(3, 129);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(47, 13);
            this.lblReceita.TabIndex = 9;
            this.lblReceita.Text = "Receita:";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(52, 274);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(3, 277);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // TelaPesquisarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPesquisarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.TelaPesquisarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.Label lblPesqPacienteID;
        private System.Windows.Forms.TextBox txtPesqMedicoID;
        private System.Windows.Forms.Label lblPesqMedID;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ListView listViewConsultas;
        private System.Windows.Forms.TextBox txtPesqPacienteID;
        private System.Windows.Forms.ColumnHeader IDConsulta;
        private System.Windows.Forms.ColumnHeader Paciente;
        private System.Windows.Forms.ColumnHeader Medico;
        private System.Windows.Forms.ColumnHeader Horario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox comboEstado;
    }
}