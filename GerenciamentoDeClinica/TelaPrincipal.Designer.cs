namespace GerenciamentoDeClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
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
            this.secretáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.especialidadeToolStripMenuItem,
            this.secretáriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
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
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
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
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
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
            this.marcarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcarToolStripMenuItem.Text = "Marcar";
            this.marcarToolStripMenuItem.Click += new System.EventHandler(this.marcarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
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
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            this.consultarToolStripMenuItem3.Click += new System.EventHandler(this.consultarToolStripMenuItem3_Click);
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
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            this.consultarToolStripMenuItem4.Click += new System.EventHandler(this.consultarToolStripMenuItem4_Click);
            // 
            // secretáriaToolStripMenuItem
            // 
            this.secretáriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem3,
            this.consultarToolStripMenuItem5});
            this.secretáriaToolStripMenuItem.Name = "secretáriaToolStripMenuItem";
            this.secretáriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.secretáriaToolStripMenuItem.Text = "Secretária";
            // 
            // cadastrarToolStripMenuItem3
            // 
            this.cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
            this.cadastrarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem3.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarToolStripMenuItem3_Click);
            // 
            // consultarToolStripMenuItem5
            // 
            this.consultarToolStripMenuItem5.Name = "consultarToolStripMenuItem5";
            this.consultarToolStripMenuItem5.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem5.Text = "Consultar";
            this.consultarToolStripMenuItem5.Click += new System.EventHandler(this.consultarToolStripMenuItem5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 78);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(230, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 78);
            this.button2.TabIndex = 2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(121, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 79);
            this.button4.TabIndex = 1;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(340, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 78);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(12, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 78);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalManager";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
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
        private System.Windows.Forms.ToolStripMenuItem secretáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}