using Biblioteca.especialidade;
using Biblioteca.fachada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaPesquisarEspecialidade : Form
    {
        List<Especialidade> listaEspecialidades;

        public TelaPesquisarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Fachada fachada = new Fachada();
            Especialidade especialidade = new Especialidade();

            if(txtPesqID.Text.Trim().Equals("") == false)
            {
                especialidade.ID_Especialidade = Convert.ToInt32(txtPesqID.Text);
            }
        }
    }
}
