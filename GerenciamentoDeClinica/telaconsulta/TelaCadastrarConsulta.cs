using Biblioteca.consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telaconsulta
{
    public partial class TelaCadastrarConsulta : Form
    {
        public TelaCadastrarConsulta()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta consulta = new Consulta();

                consulta.Horario = dateTimePicker1.Value;
                consulta.ID_Consulta = Convert.ToInt32(txtID.Text);
                consulta.Duracao = Convert.ToInt32(txtDuracao.Text);
                consulta.Descricao = txtDescricao.Text;
                consulta.Observacoes = txtObservacoes.Text;

                new ConsultaBD().Cadastrar(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
