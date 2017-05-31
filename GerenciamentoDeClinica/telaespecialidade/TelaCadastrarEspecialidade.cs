using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaCadastrarEspecialidade : Form
    {

        public TelaCadastrarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidade especialidade = new Especialidade()
                {
                    Descricao = txtDescricao.Text
                };
                new ClinicaService().CadastrarEspecialidade(especialidade);

                MessageBox.Show("Especialidade cadastrada com sucesso!");
                txtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }


        }
    }
}

