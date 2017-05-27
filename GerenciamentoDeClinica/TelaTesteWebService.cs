using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica
{
    public partial class TelaTesteWebService : Form
    {
        public TelaTesteWebService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClinicaService s = new ClinicaService();
            s.CadastrarConvenio(new Convenio { Descricao = "BILOLA" });
        }
    }
}
