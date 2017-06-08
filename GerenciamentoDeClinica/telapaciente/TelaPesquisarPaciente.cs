using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telapaciente
{
    public partial class TelaPesquisarPaciente : Form
    {
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarPaciente _pesquisarPaciente;


        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";

        public TelaPesquisarPaciente()
        {
            InitializeComponent();
        }

        private void DisableEditar()
        {
            btnAtualizar.Enabled = false;
            btnRemover.Enabled = false;

            maskedCell.Enabled = false;
            comboConvenio.Enabled = false;
            txtEmail.Enabled = false;
            rbSolteiro.Enabled = false;
            rbCasado.Enabled = false;
            rbViuvo.Enabled = false;
            txtBairro.Enabled = false;
            maskedCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            txtPais.Enabled = false;
            txtCidade.Enabled = false;
            comboUF.Enabled = false;

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();

                    else if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            comboConvenio.SelectedIndex = 0;
            dateTimeDtNasc.Value = DateTime.Now;
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;
            txtFiltroNome.Focus();

        }

        private void EnableEditar()
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            maskedCell.Enabled = true;
            comboConvenio.Enabled = true;
            txtEmail.Enabled = true;
            rbSolteiro.Enabled = true;
            rbCasado.Enabled = true;
            rbViuvo.Enabled = true;
            txtBairro.Enabled = true;
            maskedCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            txtPais.Enabled = true;
            txtCidade.Enabled = true;
            comboUF.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_pesquisarPaciente.LinhaSelecionada.HasValue)
            {
                try
                {
                    var repost = MessageBox.Show(@"Deseja remover o paciente?", @"Confirmação", MessageBoxButtons.YesNo);

                    if (repost == DialogResult.Yes)
                    {
                        ClinicaService service = new ClinicaService();
                        service.RemoverPaciente(_pesquisarPaciente.PacientesSalvos[_pesquisarPaciente.LinhaSelecionada.Value]);
                        MessageBox.Show(this, @"Paciente removido com sucesso.");
                        _pesquisarPaciente.PacientesSalvos.RemoveAt(_pesquisarPaciente.LinhaSelecionada.Value);
                        listViewPacientes.Items.RemoveAt(_pesquisarPaciente.LinhaSelecionada.Value);
                        DisableEditar();
                    }
                    else
                    {
                        DisableEditar();
                        txtFiltroNome.Focus();
                    }
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarPaciente.LinhaSelecionada.HasValue)
            {
                try
                {
                    Paciente paciente = GetPaciente();
                    paciente.ID_Paciente = _pesquisarPaciente.PacientesSalvos[_pesquisarPaciente.LinhaSelecionada.Value].ID_Paciente;
                    ValidarCamposString();
                    ClinicaService service = new ClinicaService();
                    service.AtualizarPaciente(_pesquisarPaciente.PacientesSalvos[_pesquisarPaciente.LinhaSelecionada.Value]);
                    MessageBox.Show(@"Paciente atualizado com sucesso!");

                    _pesquisarPaciente.PacientesSalvos[_pesquisarPaciente.LinhaSelecionada.Value] = paciente;

                    DisableEditar();
                }

                catch (WebException)
                {
                    MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

            listViewPacientes.Items.Clear();
            try
            {
                ClinicaService service = new ClinicaService();
                _pesquisarPaciente.PacientesSalvos = new List<Paciente>(service.ListarPaciente(new Paciente
                {
                    ID_Paciente = 0,
                    Nome = txtFiltroNome.Text,
                    CPF = maskedFiltroCPF.Text
                }));

                CarregarListView();

            }
            catch (WebException)
            {
                MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaPesquisarPaciente_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();

            comboConvenio.DataSource = new BindingList<Convenio>(service.ListarConvenio(new Convenio()));
            comboConvenio.DisplayMember = @"Descricao";

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarPaciente = ClinicaXmlUtils.GetPesquisarPaciente();
            if (_pesquisarPaciente != null)
            {
                txtFiltroNome.Text = _pesquisarPaciente.PesquisarNome;
                maskedFiltroCPF.Text = _pesquisarPaciente.PesquisarCPF;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarPaciente.LinhaSelecionada.HasValue)
                    listViewPacientes.Items[_pesquisarPaciente.LinhaSelecionada.Value].Selected = true;

                CarregarEditar(_pesquisarPaciente.Paciente);
            }
            else
            {
                _pesquisarPaciente = new PesquisarPaciente();
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPacientes.SelectedItems.Count > 0)
            {
                _pesquisarPaciente.LinhaSelecionada = listViewPacientes.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                CarregarEditar(_pesquisarPaciente.PacientesSalvos[_pesquisarPaciente.LinhaSelecionada.Value]);

                EnableEditar();
            }
            else
            {
                _pesquisarPaciente.LinhaSelecionada = null;
                DisableEditar();
            }
        }

        public void SaveXml()
        {
            _pesquisarPaciente.PesquisarNome = txtFiltroNome.Text;
            _pesquisarPaciente.PesquisarCPF = maskedFiltroCPF.Text;
            _pesquisarPaciente.Paciente = GetPaciente();

            if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarPaciente)))
            {
                //altera o cliente para um novo
                _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarPaciente);

                ClinicaXmlUtils.SetPesquisarPaciente(_pesquisarPaciente);
            }
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

        private void CarregarEditar(Paciente paciente)
        {
            txtNome.Text = paciente.Nome;
            maskedCPF.Text = paciente.CPF;
            txtRG.Text = paciente.RG;
            maskedCell.Text = paciente.Contato;
            comboConvenio.SelectedIndex = paciente.Convenio.ID_Convenio - 1;
            dateTimeDtNasc.Value = paciente.Dt_Nascimento;
            txtEmail.Text = paciente.Email;
            RadioButton radioButton = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Text == paciente.Estado_Civil);
            if (radioButton != null)
                radioButton.Checked = true;
            maskedCEP.Text = paciente.Endereco.CEP;
            txtLogradouro.Text = paciente.Endereco.Logradouro;
            txtNumero.Text = paciente.Endereco.Numero;
            txtComplemento.Text = paciente.Endereco.Complemento;
            txtBairro.Text = paciente.Endereco.Bairro;
            txtCidade.Text = paciente.Endereco.Cidade;
            comboUF.SelectedItem = paciente.Endereco.UF;
            txtPais.Text = paciente.Endereco.Pais;
        }

        private void CarregarListView()
        {
            listViewPacientes.Items.Clear();
            foreach (Paciente paciente in _pesquisarPaciente.PacientesSalvos)
            {
                ListViewItem linha = listViewPacientes.Items.Add(paciente.ID_Paciente.ToString());
                linha.SubItems.Add(paciente.Nome);
                linha.SubItems.Add(paciente.CPF);
                linha.SubItems.Add(paciente.Contato);
            }
        }

        private string GetEstadoCivil()
        {
            //Caso não seja nulo retornará o Text do RadioButton selecionado ou nulo (? = informa)
            return groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)?.Text;
        }

        //Adquirir valor do combobox UF da thread principal
        private string GetUF()
        {
            string text = null;

            Invoke(new MethodInvoker(delegate () { if (!comboUF.IsDisposed) text = comboUF.SelectedItem.ToString(); }));
            return text;
        }

        //Adquirir valor do combobox Convenio da thread principal
        private Convenio GetConvenio()
        {
            Convenio convenio = null;

            Invoke(new MethodInvoker(delegate ()
            {
                if (!comboConvenio.IsDisposed)
                    convenio = ((BindingList<Convenio>)comboConvenio.DataSource)
                        .ElementAt(comboConvenio.SelectedIndex);
            }));
            return convenio;
        }

        private Paciente GetPaciente()
        {
            return new Paciente
            {
                CPF = maskedFiltroCPF.Text,
                Convenio = GetConvenio(),
                Nome = txtNome.Text,
                RG = txtRG.Text,
                Endereco = new Endereco
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    UF = GetUF(),
                    CEP = maskedCEP.Text,
                    Pais = txtPais.Text
                },
                Contato = maskedCell.Text,
                Dt_Nascimento = dateTimeDtNasc.Value,
                Email = lblEmail.Text,
                Estado_Civil = GetEstadoCivil()
            };
        }

        private void TelaPesquisarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            if (maskedCEP.MaskFull)
            {
                Endereco endereco = ClinicaUtils.PegarEndereco(maskedCEP.Text);
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtComplemento.Text = endereco.Complemento;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    comboUF.SelectedItem = endereco.UF;

                }
            }
        }
    }


    [XmlRoot(ElementName = "pesquisar_paciente")]
    public sealed class PesquisarPaciente
    {
        [XmlElement(ElementName = "pesquisar_nome")]
        public string PesquisarNome { get; set; }
        [XmlElement(ElementName = "pesquisar_cpf")]
        public string PesquisarCPF { get; set; }
        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "pacientes_salvos")]
        public List<Paciente> PacientesSalvos { get; set; }
        public Paciente Paciente { get; set; }
    }
}

