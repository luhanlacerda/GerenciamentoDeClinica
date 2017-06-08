namespace GerenciamentoDeClinica.telaatendimento
{
    partial class TelaAtendimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.numBaia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBaia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baia";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(197, 62);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // numBaia
            // 
            this.numBaia.Location = new System.Drawing.Point(12, 36);
            this.numBaia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBaia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaia.Name = "numBaia";
            this.numBaia.Size = new System.Drawing.Size(260, 20);
            this.numBaia.TabIndex = 3;
            this.numBaia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TelaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.numBaia);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Name = "TelaAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMostrarAtendimento";
            ((System.ComponentModel.ISupportInitialize)(this.numBaia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown numBaia;
    }
}