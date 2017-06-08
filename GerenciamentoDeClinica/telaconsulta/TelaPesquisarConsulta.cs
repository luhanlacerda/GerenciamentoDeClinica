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
using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;

namespace GerenciamentoDeClinica.telaconsulta
{
    public partial class TelaPesquisarConsulta : Form, IConsistenciaDados
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarConsulta _pesquisarConsulta;

        public TelaPesquisarConsulta()
        {
            InitializeComponent();
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarConsulta.LinhaSelecionada.HasValue)
            {
                try
                {
                    Consulta line = _pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value];

                    Consulta consulta = GetConsulta();
                    consulta.ID_Consulta = line.ID_Consulta;
                    consulta.Duracao = line.Duracao;
                    consulta.Horario = line.Horario;
                    consulta.Medico.ID_Medico = line.Medico.ID_Medico;
                    consulta.Medico.Nome = line.Medico.Nome;
                    consulta.Paciente.ID_Paciente = line.Paciente.ID_Paciente;
                    consulta.Paciente.Nome = line.Paciente.Nome;
                    consulta.Secretaria.ID_Secretaria = line.Secretaria.ID_Secretaria;

                    ClinicaService service = new ClinicaService();
                    service.AtualizarConsulta(consulta);
                    MessageBox.Show(@"Consulta atualizada com sucesso!");

                    _pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value] = consulta;

                    ClearTextBoxs();
                    CarregarListView();
                    txtPesqMedicoID.Focus();
                    listViewConsultas.Items.Clear();
                    DisableEditar();
                }
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_pesquisarConsulta.LinhaSelecionada.HasValue)
            {
                try
                {
                    ClinicaService service = new ClinicaService();
                    service.RemoverConsulta(_pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value]);
                    MessageBox.Show(@"Consulta removida com sucesso!");
                    _pesquisarConsulta.ConsultasSalvas.RemoveAt(_pesquisarConsulta.LinhaSelecionada.Value);
                    listViewConsultas.Items.RemoveAt(_pesquisarConsulta.LinhaSelecionada.Value);
                    ClearTextBoxs();
                }
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                listViewConsultas.Items.Clear();
                ClinicaService service = new ClinicaService();

                Consulta consulta = new Consulta
                {
                    Medico = new Medico(),
                    Paciente = new Paciente(),
                    Secretaria = new Secretaria()
                };

                int resultMedico, resultPaciente;
                if (int.TryParse(txtPesqMedicoID.Text, out resultMedico))
                    consulta.Medico.ID_Medico = resultMedico;
                if (int.TryParse(txtPesqPacienteID.Text, out resultPaciente))
                    consulta.Paciente.ID_Paciente = resultPaciente;

                _pesquisarConsulta.ConsultasSalvas = new List<Consulta>(service.ListarConsulta(consulta));

                CarregarListView();
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


        private void listViewConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConsultas.SelectedItems.Count > 0)
            {
                _pesquisarConsulta.LinhaSelecionada = listViewConsultas.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                CarregarEditar(_pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value]);

                EnableEditar();
            }
            else
            {
                _pesquisarConsulta.LinhaSelecionada = null;
                ClearTextBoxs();
                DisableEditar();
            }
        }

        private void DisableEditar()
        {
            txtObservacoes.Enabled = false;
            txtReceita.Enabled = false;
            comboEstado.Enabled = false;
            btnAtualizar.Enabled = false;
            btnRemover.Enabled = false;

            txtObservacoes.Clear();
            txtReceita.Clear();
        }

        private void EnableEditar()
        {
            txtObservacoes.Enabled = true;
            txtReceita.Enabled = true;
            comboEstado.Enabled = true;
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;
        }


        private void TelaPesquisarConsulta_Load(object sender, EventArgs e)
        {
            ClinicaService service = new ClinicaService();

            comboEstado.DataSource = new BindingList<Estado>(service.ListarEstado(new Estado()));
            comboEstado.DisplayMember = "Descricao";

            txtObservacoes.Enabled = false;
            txtReceita.Enabled = false;
            comboEstado.Enabled = false;

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarConsulta = ClinicaXmlUtils.GetPesquisarConsulta();
            if (_pesquisarConsulta != null)
            {
                txtPesqMedicoID.Text = _pesquisarConsulta.PesquisarID_Medico;
                txtPesqPacienteID.Text = _pesquisarConsulta.PesquisarID_Paciente;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarConsulta.LinhaSelecionada.HasValue)
                    listViewConsultas.Items[_pesquisarConsulta.LinhaSelecionada.Value].Selected = true;

                CarregarEditar(_pesquisarConsulta.Consulta);
            }
            else
            {
                _pesquisarConsulta = new PesquisarConsulta();
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }


        private void CarregarEditar(Consulta consulta)
        {
            if (consulta.Medico.ID_Medico > 0)
                txtPesqMedicoID.Text = consulta.Medico.ID_Medico.ToString();
            if (consulta.Paciente.ID_Paciente > 0)
                txtPesqPacienteID.Text = consulta.Paciente.ID_Paciente.ToString();
            comboEstado.SelectedIndex = consulta.Estado.ID_Estado - 1;
            txtObservacoes.Text = consulta.Observacoes;
            txtReceita.Text = consulta.Receita;

        }


        private void CarregarListView()
        {
            foreach (Consulta consulta in _pesquisarConsulta.ConsultasSalvas)
            {
                ListViewItem linha = listViewConsultas.Items.Add(Convert.ToString(consulta.ID_Consulta));
                linha.SubItems.Add(consulta.Paciente.Nome);
                linha.SubItems.Add(consulta.Medico.Nome);
                linha.SubItems.Add(Convert.ToString(consulta.Horario));
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


        void ClearTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            comboEstado.SelectedIndex = 0;

        }


        private Consulta GetConsulta()
        {
            Consulta consulta = new Consulta
            {
                Estado = GetEstado(),
                Paciente = new Paciente(),
                Medico = new Medico(),
                Secretaria = new Secretaria(),
                Observacoes = txtObservacoes.Text,
                Receita = txtReceita.Text
            };

            int resultPaciente, resultMedico;

            if (int.TryParse(txtPesqPacienteID.Text, out resultPaciente))
                consulta.Paciente.ID_Paciente = resultPaciente;
            if (int.TryParse(txtPesqMedicoID.Text, out resultMedico))
                consulta.Medico.ID_Medico = resultMedico;

            return consulta;
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
            _pesquisarConsulta.PesquisarID_Medico = txtPesqMedicoID.Text;
            _pesquisarConsulta.PesquisarID_Paciente = txtPesqPacienteID.Text;
            _pesquisarConsulta.Consulta = GetConsulta();

            if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarConsulta)))
            {
                //altera o cliente para um novo
                _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarConsulta);

                ClinicaXmlUtils.SetPesquisarConsulta(_pesquisarConsulta);
            }
        }

        private void TelaPesquisarConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXml();
        }


    }

    [XmlRoot(ElementName = "pesquisar_consulta")]
    public sealed class PesquisarConsulta
    {
        [XmlElement(ElementName = "pesquisar_id_medico")]
        public string PesquisarID_Medico { get; set; }

        [XmlElement(ElementName = "pesquisar_id_paciente")]
        public string PesquisarID_Paciente { get; set; }

        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "consultas_salvas")]
        public List<Consulta> ConsultasSalvas { get; set; }
        public Consulta Consulta { get; set; }
    }
}