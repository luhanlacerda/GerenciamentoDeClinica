using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeClinica.localhost;

namespace GerenciamentoDeClinica.telaconsulta
{
    public partial class TelaPesquisarConsulta : Form
    {
        private List<Consulta> _consultas;
        private int? _selectedRowConsulta;

        public TelaPesquisarConsulta()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                listViewConsultas.Items.Clear();
                ClinicaService service = new ClinicaService();
                _consultas = new List<Consulta>(service.ListarConsulta(new Consulta
                {
                    Medico = new Medico { ID_Medico = Convert.ToInt32(txtPesqMedicoID.Text) },
                    Paciente = new Paciente { ID_Paciente = Convert.ToInt32(txtPesqPacienteID.Text) }

                }));
                foreach (Consulta consulta in _consultas)
                {
                    ListViewItem linha = listViewConsultas.Items.Add(Convert.ToString(consulta.ID_Consulta));
                    linha.SubItems.Add(consulta.Paciente.Nome);
                    linha.SubItems.Add(consulta.Medico.Nome);
                    linha.SubItems.Add(Convert.ToString(consulta.Horario));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void listViewConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConsultas.SelectedItems.Count > 0)
            {
                _selectedRowConsulta = listViewConsultas.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                txtObservacoes.Text = _consultas[_selectedRowConsulta.Value].Observacoes;
                txtReceita.Text = _consultas[_selectedRowConsulta.Value].Receita;
                txtObservacoes.Enabled = true;
                txtReceita.Enabled = true;
                comboEstado.Enabled = true;
            }
            else
            {
                _selectedRowConsulta = null;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_selectedRowConsulta.HasValue)
            {
                try
                {
                    #region Dados
                    _consultas[_selectedRowConsulta.Value].Observacoes = txtObservacoes.Text;
                    _consultas[_selectedRowConsulta.Value].Receita = txtReceita.Text;
                    _consultas[_selectedRowConsulta.Value].Estado = ((BindingList<Estado>)comboEstado.DataSource).ElementAt(comboEstado.SelectedIndex);
                    #endregion

                    ClinicaService service = new ClinicaService();
                    service.AtualizarConsulta(_consultas[_selectedRowConsulta.Value]);
                    MessageBox.Show("Consulta atualizada com sucesso!");

                    listViewConsultas.Items.Clear();
                    _consultas = new List<Consulta>(service.ListarConsulta(new Consulta
                    {
                        Medico = new Medico { ID_Medico = Convert.ToInt32(txtPesqMedicoID.Text) },
                        Paciente = new Paciente { ID_Paciente = Convert.ToInt32(txtPesqPacienteID.Text) }

                    }));
                    foreach (Consulta consulta in _consultas)
                    {
                        ListViewItem linha = listViewConsultas.Items.Add(Convert.ToString(consulta.ID_Consulta));
                        linha.SubItems.Add(consulta.Paciente.Nome);
                        linha.SubItems.Add(consulta.Medico.Nome);
                        linha.SubItems.Add(Convert.ToString(consulta.Horario));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TelaPesquisarConsulta_Load(object sender, EventArgs e)
        {
            ClinicaService service = new ClinicaService();

            comboEstado.DataSource = new BindingList<Estado>(service.ListarEstado(new Estado()));
            comboEstado.DisplayMember = "Descricao";

            txtObservacoes.Enabled = false;
            txtReceita.Enabled = false;
            comboEstado.Enabled = false;
        }
    }
}
