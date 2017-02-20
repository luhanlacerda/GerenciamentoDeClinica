using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.Telas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        TelaCadastroMedico TelaCadastrarMedico;
        private void cadastrarMedicos_Click(object sender, EventArgs e)
        {
            if(TelaCadastrarMedico == null)
            {
                TelaCadastrarMedico = new TelaCadastroMedico();
                TelaCadastrarMedico.MdiParent = this;
                TelaCadastrarMedico.FormClosed += TelaCadastrarMedico_FormClosed;
                TelaCadastrarMedico.Show();
            }
            else
            {
                TelaCadastrarMedico.Activate();
            }
        }

        private void TelaCadastrarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaCadastrarMedico = null;
            //throw new NotImplementedException();
        }
    }
}
