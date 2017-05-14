namespace GerenciamentoDeClinica.consulta
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.txtDuracao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblDuracao);
            this.groupBox1.Controls.Add(this.lblObservacoes);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Consulta";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 154);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(385, 79);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(24, 282);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(385, 79);
            this.txtObservacoes.TabIndex = 3;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(165, 63);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(132, 20);
            this.txtDuracao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 121);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(162, 44);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(51, 13);
            this.lblDuracao.TabIndex = 4;
            this.lblDuracao.Text = "Duração:";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(21, 250);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 2;
            this.lblObservacoes.Text = "Observações:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(21, 44);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 1;
            this.lblHorario.Text = "Horário:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(334, 378);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // TelaCadastrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCadastrarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}