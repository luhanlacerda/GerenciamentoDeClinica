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

namespace GerenciamentoDeClinica.telasecretaria
{
    public partial class TelaPesquisarSecretaria : Form
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarSecretaria _pesquisarSecretaria;
    

        public TelaPesquisarSecretaria()
        {
            InitializeComponent();
        }

        private void TelaPesquisarSecretaria_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarSecretaria = ClinicaXmlUtils.GetPesquisarSecretaria();
            if (_pesquisarSecretaria != null)
            {
                txtNomePesq.Text = _pesquisarSecretaria.PesquisarNome;
                maskedCPFPesq.Text = _pesquisarSecretaria.PesquisarCPF;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarSecretaria.LinhaSelecionada.HasValue)
                    listViewSecretarias.Items[_pesquisarSecretaria.LinhaSelecionada.Value].Selected = true;

                CarregarEditar(_pesquisarSecretaria.Secretaria);
            }
            else
            {
                _pesquisarSecretaria = new PesquisarSecretaria();
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();

        }

        private void EnableEditar()
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            maskedContato.Enabled = true;
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

            maskedContato.Enabled = false;
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
            txtNome.Clear();
            maskedCPF.Clear();
            txtRG.Clear();
            maskedContato.Clear();
            dateTimeDtNasc.Value = DateTime.Now;
            txtEmail.Clear();
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;
            maskedCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            comboUF.SelectedIndex = 0;
            txtPais.Clear();
            listViewSecretarias.SelectedItems.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewSecretarias.Items.Clear();
            try
            {
                ClinicaService service = new ClinicaService();
                _pesquisarSecretaria.SecretariasSalvas = new List<Secretaria>(service.ListarSecretaria(new Secretaria
                {
                    Nome = txtNomePesq.Text,
                    CPF = maskedCPFPesq.Text
                }));
                CarregarListView();

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

        private void listViewSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSecretarias.SelectedItems.Count > 0)
            {
                _pesquisarSecretaria.LinhaSelecionada = listViewSecretarias.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                CarregarEditar(_pesquisarSecretaria.SecretariasSalvas[_pesquisarSecretaria.LinhaSelecionada.Value]);

                EnableEditar();
            }
            else
            {
                _pesquisarSecretaria.LinhaSelecionada = null;
                DisableEditar();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarSecretaria.LinhaSelecionada.HasValue)
            {
                try
                {
                    Secretaria secretaria = GetSecretaria();
                    secretaria.ID_Secretaria = _pesquisarSecretaria.SecretariasSalvas[_pesquisarSecretaria.LinhaSelecionada.Value].ID_Secretaria;
                    ValidarCamposString();
                    ClinicaService service = new ClinicaService();
                    service.AtualizarSecretaria(_pesquisarSecretaria.SecretariasSalvas[_pesquisarSecretaria.LinhaSelecionada.Value]);
                    MessageBox.Show(@"Secretária atualizado com sucesso!");

                    _pesquisarSecretaria.SecretariasSalvas[_pesquisarSecretaria.LinhaSelecionada.Value] = secretaria;

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
            if (_pesquisarSecretaria.LinhaSelecionada.HasValue)
            {
                try
                {
                    ClinicaService service = new ClinicaService();
                    service.RemoverSecretaria(_pesquisarSecretaria.SecretariasSalvas[_pesquisarSecretaria.LinhaSelecionada.Value]);
                    MessageBox.Show(@"Secretária removida com sucesso!");
                    _pesquisarSecretaria.SecretariasSalvas.RemoveAt(_pesquisarSecretaria.LinhaSelecionada.Value);
                    listViewSecretarias.Items.RemoveAt(_pesquisarSecretaria.LinhaSelecionada.Value);
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

        //Adquirir valor do combobox UF da thread principal
        private string GetUF()
        {
            string text = null;

            Invoke(new MethodInvoker(delegate () { if (!comboUF.IsDisposed) text = comboUF.SelectedItem.ToString(); }));
            return text;
        }

        private string GetEstadoCivil()
        {
            //Caso não seja nulo retornará o Text do RadioButton selecionado ou nulo (? = informa)
            return groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)?.Text;
        }

        private Secretaria GetSecretaria()
        {
            return new Secretaria
            {
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
                Contato = maskedContato.Text,
                Dt_Nascimento = dateTimeDtNasc.Value,
                Email = txtEmail.Text,
                Estado_Civil = GetEstadoCivil()
            };
        }

        private void CarregarEditar(Secretaria secretaria)
        {
            txtNome.Text = secretaria.Nome;
            maskedCPF.Text = secretaria.CPF;
            txtRG.Text = secretaria.RG;
            maskedContato.Text = secretaria.Contato;
            dateTimeDtNasc.Value = secretaria.Dt_Nascimento;
            txtEmail.Text = secretaria.Email;
            RadioButton radioButton = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Text == secretaria.Estado_Civil);
            if (radioButton != null)
                radioButton.Checked = true;
            maskedCEP.Text = secretaria.Endereco.CEP;
            txtLogradouro.Text = secretaria.Endereco.Logradouro;
            txtNumero.Text = secretaria.Endereco.Numero;
            txtComplemento.Text = secretaria.Endereco.Complemento;
            txtBairro.Text = secretaria.Endereco.Bairro;
            txtCidade.Text = secretaria.Endereco.Cidade;
            comboUF.SelectedItem = secretaria.Endereco.UF;
            txtPais.Text = secretaria.Endereco.Pais;
        }

        private void ValidarCamposString()
        {
            //Nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show(this, @"Informe o nome");
            }

            //CPF
            if (string.IsNullOrEmpty(maskedCPF.Text))
            {
                MessageBox.Show(this, @"Informe o CPF");
            }

            //RG
            if (string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show(this, @"Informe o RG");
            }

            //Contato
            if (string.IsNullOrEmpty(maskedContato.Text))
            {
                MessageBox.Show(this, @"Informe o número de contato");
            }

            //Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(this, @"Informe o email");
            }

            //CEP
            if (string.IsNullOrEmpty(maskedCEP.Text))
            {
                MessageBox.Show(this, @"Informe o CEP");
            }

            //Logradouro
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                MessageBox.Show(this, @"Informe o logradouro");
            }

            //Numero
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show(this, @"Informe o numero do endereço");
            }

            //Complemento
            if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show(this, @"Informe o complemento");
            }

            //Bairro
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show(this, @"Informe o bairro");
            }

            //Cidade
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show(this, @"Informe a cidade");
            }

            //País
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show(this, @"Informe o país");
            }
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

        private void CarregarListView()
        {
            foreach (Secretaria secretaria in _pesquisarSecretaria.SecretariasSalvas)
            {
                ListViewItem linha = listViewSecretarias.Items.Add(secretaria.Nome);
                linha.SubItems.Add(secretaria.CPF);
                linha.SubItems.Add(secretaria.Contato);
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
            _pesquisarSecretaria.PesquisarNome = txtNomePesq.Text;
            _pesquisarSecretaria.PesquisarCPF = maskedCPFPesq.Text;
            _pesquisarSecretaria.Secretaria = GetSecretaria();

            if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarSecretaria)))
            {
                //altera o cliente para um novo
                _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarSecretaria);

                ClinicaXmlUtils.SetPesquisarSecretaria(_pesquisarSecretaria);
            }
        }

        private void TelaPesquisarSecretaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "pesquisar_secretaria")]
    public sealed class PesquisarSecretaria
    {
        [XmlElement(ElementName = "pesquisar_nome")]
        public string PesquisarNome { get; set; }
        [XmlElement(ElementName = "pesquisar_cpf")]
        public string PesquisarCPF { get; set; }
        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "secretarias_salvas")]
        public List<Secretaria> SecretariasSalvas { get; set; }
        public Secretaria Secretaria { get; set; }
    }
}
