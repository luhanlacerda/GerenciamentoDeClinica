namespace telas
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testarConexãoBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.convênioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.convênioToolStripMenuItem,
            this.especialidadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testarConexãoBDToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // testarConexãoBDToolStripMenuItem
            // 
            this.testarConexãoBDToolStripMenuItem.Name = "testarConexãoBDToolStripMenuItem";
            this.testarConexãoBDToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.testarConexãoBDToolStripMenuItem.Text = "Testar Conexão BD";
            this.testarConexãoBDToolStripMenuItem.Click += new System.EventHandler(this.testarConexãoBDToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMedicos,
            this.consultarToolStripMenuItem});
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.médicosToolStripMenuItem.Text = "Médicos";
            // 
            // cadastrarMedicos
            // 
            this.cadastrarMedicos.Name = "cadastrarMedicos";
            this.cadastrarMedicos.Size = new System.Drawing.Size(125, 22);
            this.cadastrarMedicos.Text = "Cadastrar";
            this.cadastrarMedicos.Click += new System.EventHandler(this.cadastrarMedicos_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarToolStripMenuItem,
            this.consultarToolStripMenuItem2});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // marcarToolStripMenuItem
            // 
            this.marcarToolStripMenuItem.Name = "marcarToolStripMenuItem";
            this.marcarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.marcarToolStripMenuItem.Text = "Marcar";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // convênioToolStripMenuItem
            // 
            this.convênioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.consultarToolStripMenuItem3});
            this.convênioToolStripMenuItem.Name = "convênioToolStripMenuItem";
            this.convênioToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.convênioToolStripMenuItem.Text = "Convênio";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            // 
            // especialidadeToolStripMenuItem
            // 
            this.especialidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.consultarToolStripMenuItem4});
            this.especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            this.especialidadeToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.especialidadeToolStripMenuItem.Text = "Especialidade";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMedicos;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem convênioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem especialidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem testarConexãoBDToolStripMenuItem;
    }
}