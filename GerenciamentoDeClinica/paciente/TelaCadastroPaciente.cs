using Biblioteca.paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.paciente
{
    public partial class TelaCadastroPaciente : Form
    {
        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void clearAll(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
