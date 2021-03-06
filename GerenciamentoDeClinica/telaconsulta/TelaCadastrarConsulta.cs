﻿using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telaconsulta
{
    public partial class TelaCadastrarConsulta : Form, IConsistenciaDados
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private CadastrarConsulta _cadastrarConsulta;
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private List<Medico> _medicos;
        private List<Paciente> _pacientes;
        private List<Secretaria> _secretarias;
        private int? _selectedRowPaciente, _selectedRowMedico, _selectedRowSecretaria;

        public TelaCadastrarConsulta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                _cadastrarConsulta.Consulta = GetConsulta();

                ClinicaService service = new ClinicaService();
                service.CadastrarConsulta(_cadastrarConsulta.Consulta);
                MessageBox.Show(@"Consulta marcada com sucesso!");

                ClearTextBoxs();
            }
            catch (WebException)
            {
                MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                listViewPacientes.Items.Clear();
                ClinicaService service = new ClinicaService();
                _pacientes = new List<Paciente>(service.ListarPaciente(new Paciente
                {
                    Nome = txtNomePaciente.Text
                }));
                foreach (Paciente paciente in _pacientes)
                {
                    ListViewItem linha = listViewPacientes.Items.Add(paciente.Nome);
                    linha.SubItems.Add(paciente.CPF);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnPesquisarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                listViewMedicos.Items.Clear();
                ClinicaService service = new ClinicaService();
                _medicos = new List<Medico>(service.ListarMedico(new Medico
                {
                    Nome = txtNomeMedico.Text
                }));
                foreach (Medico medico in _medicos)
                {
                    ListViewItem linha = listViewMedicos.Items.Add(medico.Nome);
                    linha.SubItems.Add(medico.CRM);
                    linha.SubItems.Add(medico.Especialidade.Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnPesquisarSecretaria_Click(object sender, EventArgs e)
        {
            try
            {
                listViewSecretarias.Items.Clear();
                ClinicaService service = new ClinicaService();
                _secretarias = new List<Secretaria>(service.ListarSecretaria(new Secretaria
                {
                    Nome = txtNomeSecretaria.Text
                }));
                foreach (Secretaria secretaria in _secretarias)
                {
                    ListViewItem linha = listViewSecretarias.Items.Add(secretaria.Nome);
                    linha.SubItems.Add(secretaria.CPF);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void listViewMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedicos.SelectedItems.Count > 0)
            {
                _selectedRowMedico = listViewMedicos.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;
                txtIDMedico.Text = _medicos[_selectedRowMedico.Value].ID_Medico.ToString();
            }
        }

        private void listViewSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSecretarias.SelectedItems.Count > 0)
            {
                _selectedRowSecretaria = listViewSecretarias.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;
                txtIDSecretaria.Text = _secretarias[_selectedRowSecretaria.Value].ID_Secretaria.ToString();
            }
        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPacientes.SelectedItems.Count > 0)
            {
                _selectedRowPaciente = listViewPacientes.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;
                txtIDPaciente.Text = _pacientes[_selectedRowPaciente.Value].ID_Paciente.ToString();
            }
        }

        private void TelaCadastrarConsulta_Load(object sender, EventArgs e)
        {
            ClinicaService service = new ClinicaService();
            comboEstado.DataSource = new BindingList<Estado>(service.ListarEstado(new Estado()));
            comboEstado.DisplayMember = "Descricao";

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarConsulta = ClinicaXmlUtils.GetCadastrarConsulta();
            if (_cadastrarConsulta != null)
                CarregarEditar(_cadastrarConsulta.Consulta);
            else
                _cadastrarConsulta = new CadastrarConsulta { Consulta = new Consulta() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        public void SalvarDados()
        {
            //Executa enquanto o Form for executado
            while (Visible)
            {
                SaveXml();

                //Salvar a cada 1.5s
                Thread.Sleep(1500);
            }
        }

        public void SaveXml()
        {
            _cadastrarConsulta.Consulta = GetConsulta();

            if (!_savedCadastrar.Equals(ClinicaXmlUtils.ToXml(_cadastrarConsulta)))
            {
                //altera a consulta para um novo
                _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarConsulta);

                ClinicaXmlUtils.SetCadastrarConsulta(_cadastrarConsulta);
            }
        }

        private Estado GetEstado()
        {
            Estado estado = null;

            Invoke(new MethodInvoker(delegate ()
            {
                if (!comboEstado.IsDisposed)
                    estado = ((BindingList<Estado>)comboEstado.DataSource)
                        .ElementAt(comboEstado.SelectedIndex);
            }));
            return estado;
        }

        private void ClearTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            comboEstado.SelectedIndex = 0;
            dateTimeDia.Value = DateTime.Now;

        }

        private void CarregarEditar(Consulta consulta)
        {
            txtDuracao.Text = Convert.ToString(consulta.Duracao);
            dateTimeDia.Value = consulta.Horario;
            comboEstado.SelectedIndex = consulta.Estado.ID_Estado - 1;
            txtNomePaciente.Text = consulta.Paciente.Nome;
            txtIDPaciente.Text = Convert.ToString(consulta.Paciente.ID_Paciente);
            txtNomeMedico.Text = consulta.Medico.Nome;
            txtIDMedico.Text = Convert.ToString(consulta.Medico.ID_Medico);
            txtNomeSecretaria.Text = consulta.Secretaria.Nome;
            txtIDSecretaria.Text = Convert.ToString(consulta.Secretaria.ID_Secretaria);

        }

        private void TelaCadastrarConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }

        private Consulta GetConsulta()
        {
            int result;
            Consulta consulta = new Consulta
            {
                Horario = dateTimeDia.Value,
                Estado = GetEstado(),
                Paciente = new Paciente(),
                Medico = new Medico(),
                Secretaria = new Secretaria()
            };

            if (int.TryParse(txtDuracao.Text, out result))
                consulta.Duracao = result;
            if (int.TryParse(txtIDPaciente.Text, out result))
                consulta.Paciente.ID_Paciente = result;
            if (int.TryParse(txtIDMedico.Text, out result))
                consulta.Medico.ID_Medico = result;
            if (int.TryParse(txtIDSecretaria.Text, out result))
                consulta.Secretaria.ID_Secretaria = result;

            return consulta;
        }
    }


    [XmlRoot(ElementName = "cadastrar_consulta")]
    public sealed class CadastrarConsulta
    {
        public Consulta Consulta { get; set; }
        [XmlElement(ElementName = "pacientes_salvos")]
        public List<Paciente> PacientesSalvos { get; set; }
        [XmlElement(ElementName = "medicos_salvos")]
        public List<Medico> MedicosSalvos { get; set; }
        [XmlElement(ElementName = "secretarias_salvas")]
        public List<Secretaria> SecretariasSalvas { get; set; }
    }
}