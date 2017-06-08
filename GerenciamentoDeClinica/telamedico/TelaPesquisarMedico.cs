using GerenciamentoDeClinica.localhost;
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

namespace GerenciamentoDeClinica.telamedico
{
    public partial class TelaPesquisarMedico : Form, IConsistenciaDados
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarMedico _pesquisarMedico;

        public TelaPesquisarMedico()
        {
            InitializeComponent();
        }

        private void TelaPesquisarMedico_Load(object sender, EventArgs e)
        {
            // Create settings
            //string a = Properties.Settings.Default.local;
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();
            comboEspecialidade.DataSource = new BindingList<Especialidade>(service.ListarEspecialidade(new Especialidade()));
            comboEspecialidade.DisplayMember = "Descricao";

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarMedico = ClinicaXmlUtils.GetPesquisarMedico();
            if (_pesquisarMedico != null)
            {
                txtPesqNome.Text = _pesquisarMedico.PesquisarNome;
                txtPesqCRM.Text = _pesquisarMedico.PesquisarCRM;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarMedico.LinhaSelecionada.HasValue)
                    listMedicos.Items[_pesquisarMedico.LinhaSelecionada.Value].Selected = true;

                CarregarEditar(_pesquisarMedico.Medico);
            }
            else
            {
                _pesquisarMedico = new PesquisarMedico();
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void EnableEditar()
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            maskedCell.Enabled = true;
            comboEspecialidade.Enabled = true;
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

        private void DisableEditar()
        {
            btnAtualizar.Enabled = false;
            btnRemover.Enabled = false;

            maskedCell.Enabled = false;
            comboEspecialidade.Enabled = false;
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

            ClearTextBoxs();
            comboEspecialidade.SelectedIndex = 0;
            dateTimeDtNasc.Value = DateTime.Now;
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;
            comboUF.SelectedIndex = 0;
            listMedicos.SelectedItems.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                listMedicos.Items.Clear();

                ClinicaService service = new ClinicaService();
                _pesquisarMedico.MedicosSalvos = new List<Medico>(service.ListarMedico(new Medico
                {
                    Nome = txtPesqNome.Text,
                    CRM = txtPesqCRM.Text
                }));
                CarregarListView();

                DisableEditar();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarMedico.LinhaSelecionada.HasValue)
            {
                try
                {
                    Medico medico = GetMedico();
                    medico.ID_Medico = _pesquisarMedico.MedicosSalvos[_pesquisarMedico.LinhaSelecionada.Value].ID_Medico;

                    ClinicaService service = new ClinicaService();
                    service.AtualizarMedico(medico);
                    MessageBox.Show(@"Médico atualizado com sucesso!");

                    _pesquisarMedico.MedicosSalvos[_pesquisarMedico.LinhaSelecionada.Value] = medico;
                    
                    DisableEditar();
                    txtPesqNome.Focus();
                    listMedicos.Items.Clear();
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
            if (_pesquisarMedico.LinhaSelecionada.HasValue)
            {
                try
                {

                    var repost = MessageBox.Show(@"Deseja remover o médico?", @"Confirmação", MessageBoxButtons.YesNo);

                    if (repost == DialogResult.Yes)
                    {
                        ClinicaService service = new ClinicaService();
                        service.RemoverMedico(_pesquisarMedico.MedicosSalvos[_pesquisarMedico.LinhaSelecionada.Value]);
                        MessageBox.Show(@"Médico removido com sucesso!");
                        _pesquisarMedico.MedicosSalvos.RemoveAt(_pesquisarMedico.LinhaSelecionada.Value);
                        listMedicos.Items.RemoveAt(_pesquisarMedico.LinhaSelecionada.Value);
                        DisableEditar();
                        listMedicos.Items.Clear();
                        txtPesqNome.Focus();

                    }
                    else
                    {
                        DisableEditar();
                        txtPesqNome.Focus();
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

        private void listMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMedicos.SelectedItems.Count > 0)
            {
                _pesquisarMedico.LinhaSelecionada = listMedicos.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                CarregarEditar(_pesquisarMedico.MedicosSalvos[_pesquisarMedico.LinhaSelecionada.Value]);

                EnableEditar();
            }
            else
            {
                _pesquisarMedico.LinhaSelecionada = null;
                DisableEditar();
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

        public void SaveXml()
        {
            _pesquisarMedico.PesquisarNome = txtPesqNome.Text;
            _pesquisarMedico.PesquisarCRM = txtPesqCRM.Text;
            _pesquisarMedico.Medico = GetMedico();

            if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarMedico)))
            {
                //altera o cliente para um novo
                _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarMedico);

                ClinicaXmlUtils.SetPesquisarMedico(_pesquisarMedico);
            }
        }

        private void CarregarListView()
        {
            listMedicos.Items.Clear();
            foreach (Medico medico in _pesquisarMedico.MedicosSalvos)
            {
                ListViewItem linha = listMedicos.Items.Add(medico.ID_Medico.ToString());
                linha.SubItems.Add(medico.Nome);
                linha.SubItems.Add(medico.CRM);
            }
        }

        private void CarregarEditar(Medico medico)
        {
            txtNome.Text = medico.Nome;
            maskedCPF.Text = medico.CPF;
            txtRG.Text = medico.RG;
            maskedCell.Text = medico.Contato;
            txtCRM.Text = medico.CRM;
            comboEspecialidade.SelectedIndex = medico.Especialidade.ID_Especialidade - 1;
            dateTimeDtNasc.Value = medico.Dt_Nascimento;
            txtEmail.Text = medico.Email;
            RadioButton radioButton = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Text == medico.Estado_Civil);
            if (radioButton != null)
                radioButton.Checked = true;
            maskedCEP.Text = medico.Endereco.CEP;
            txtLogradouro.Text = medico.Endereco.Logradouro;
            txtNumero.Text = medico.Endereco.Numero;
            txtComplemento.Text = medico.Endereco.Complemento;
            txtBairro.Text = medico.Endereco.Bairro;
            txtCidade.Text = medico.Endereco.Cidade;
            comboUF.SelectedItem = medico.Endereco.UF;
            txtPais.Text = medico.Endereco.Pais;
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

        //Adquirir valor do combobox Especialidade da thread principal
        private Especialidade GetEspecialidade()
        {
            Especialidade especialidade = null;

            Invoke(new MethodInvoker(delegate ()
            {
                if (!comboEspecialidade.IsDisposed)
                    especialidade = ((BindingList<Especialidade>)comboEspecialidade.DataSource)
                    .ElementAt(comboEspecialidade.SelectedIndex);
            }));
            return especialidade;
        }

        private Medico GetMedico()
        {
            return new Medico
            {
                CRM = txtCRM.Text,
                Especialidade = GetEspecialidade(),
                Nome = txtNome.Text,
                RG = txtRG.Text,
                CPF = maskedCPF.Text,
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
                Email = txtEmail.Text,
                Estado_Civil = GetEstadoCivil()
            };
        }

        void ClearTextBoxs()
        {
            GroupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            GroupBox.Controls.OfType<MaskedTextBox>().ToList().ForEach(t => t.Clear());

        }

        private void TelaPesquisarMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "pesquisar_medico")]
    public sealed class PesquisarMedico
    {
        [XmlElement(ElementName = "pesquisar_nome")]
        public string PesquisarNome { get; set; }
        [XmlElement(ElementName = "pesquisar_crm")]
        public string PesquisarCRM { get; set; }
        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "medicos_salvos")]
        public List<Medico> MedicosSalvos { get; set; }
        public Medico Medico { get; set; }
    }
}
