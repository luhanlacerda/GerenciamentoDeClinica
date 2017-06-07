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
        private List<Consulta> _consultas;
        private int? _selectedRowConsulta;
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarConsulta _pesquisarConsulta;

        public TelaPesquisarConsulta()
        {
            InitializeComponent();
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_selectedRowConsulta.HasValue)
            {
                try
                {

                    /*#region Dados

                    _consultas[_selectedRowConsulta.Value].Observacoes = txtObservacoes.Text;
                    _consultas[_selectedRowConsulta.Value].Receita = txtReceita.Text;
                    _consultas[_selectedRowConsulta.Value].Estado =
                        ((BindingList<Estado>)comboEstado.DataSource).ElementAt(comboEstado.SelectedIndex);

                    #endregion

                    ClinicaService service = new ClinicaService();
                    service.AtualizarConsulta(_consultas[_selectedRowConsulta.Value]);
                    MessageBox.Show(@"Consulta atualizada com sucesso!");

                    listViewConsultas.Items.Clear();
                    _consultas = new List<Consulta>(service.ListarConsulta(new Consulta

                    {
                        Medico = new Medico { ID_Medico = Convert.ToInt32(txtPesqMedicoID.Text) },
                        Paciente = new Paciente { ID_Paciente = Convert.ToInt32(txtPesqPacienteID.Text) }
                    }));*/

                    Consulta consulta = GetConsulta();
                    consulta.ID_Consulta = _pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value].ID_Consulta;

                    ClinicaService service = new ClinicaService();
                    service.AtualizarConsulta(_pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value]);
                    MessageBox.Show(@"Consulta atualizada com sucesso!");

                    _pesquisarConsulta.ConsultasSalvas[_pesquisarConsulta.LinhaSelecionada.Value] = consulta;

                    ClearTextBoxs();
                    CarregarListView();
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
                _consultas = new List<Consulta>(service.ListarConsulta(new Consulta

                {
                    Medico = new Medico { ID_Medico = Convert.ToInt32(txtPesqMedicoID.Text) },
                    Paciente = new Paciente { ID_Paciente = Convert.ToInt32(txtPesqPacienteID.Text) }
                }));

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

                txtObservacoes.Enabled = true;
                txtReceita.Enabled = true;
                comboEstado.Enabled = true;
            }
            else
            {
                _pesquisarConsulta.LinhaSelecionada = null;
                ClearTextBoxs();
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

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarConsulta= ClinicaXmlUtils.GetPesquisarConsulta();
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
            txtPesqMedicoID.Text = Convert.ToString(consulta.Duracao);
            comboEstado.SelectedIndex = consulta.Estado.ID_Estado - 1;
            txtPesqPacienteID.Text = Convert.ToString(consulta.Paciente.ID_Paciente);
            txtObservacoes.Text = consulta.Observacoes;
            txtReceita.Text = consulta.Receita;

        }


        private void CarregarListView()
        {
            foreach (Consulta consulta in _consultas)
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
            return new Consulta
            {

                Estado = GetEstado(),
                Paciente = new Paciente
                {
                    ID_Paciente = Convert.ToInt32(txtPesqPacienteID.Text)
                },

                Medico = new Medico
                {
                    ID_Medico = Convert.ToInt32(txtPesqMedicoID.Text)
                },

            };
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
        [XmlElement(ElementName = "consultas_salvos")]
        public List<Consulta> ConsultasSalvas { get; set; }
        public Consulta Consulta { get; set; }
    }
}