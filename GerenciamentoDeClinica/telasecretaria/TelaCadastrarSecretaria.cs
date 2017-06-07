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
    public partial class TelaCadastrarSecretaria : Form, IConsistenciaDados
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private CadastrarSecretaria _cadastrarSecretaria;

        public TelaCadastrarSecretaria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposString();
                _cadastrarSecretaria.Secretaria = GetSecretaria();

                ClinicaService service = new ClinicaService();
                service.CadastrarSecretaria(_cadastrarSecretaria.Secretaria);
                MessageBox.Show(@"Secretária cadastrada com sucesso!");

                LimparCampos();

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

        private void TelaCadastrarSecretaria_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;
            //txtPais.Text = "Brasil";
            txtPais.Enabled = true;

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarSecretaria = ClinicaXmlUtils.GetCadastrarSecretaria();
            if (_cadastrarSecretaria != null)
                CarregarEditar(_cadastrarSecretaria.Secretaria);
            else
                _cadastrarSecretaria = new CadastrarSecretaria { Secretaria = new Secretaria() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
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

        private void LimparCampos()
        {
            txtNome.Clear();
            txtRG.Clear();
            maskedCPF.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            maskedCEP.Clear();
            txtCidade.Clear();
            txtPais.Clear();
            maskedContato.Clear();
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;
            dateTimeDtNasc.Value = DateTime.Now;
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
            _cadastrarSecretaria.Secretaria = GetSecretaria();

            if (!_savedCadastrar.Equals(ClinicaXmlUtils.ToXml(_cadastrarSecretaria)))
            {
                //altera a secretaria para uma nova
                _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarSecretaria);

                ClinicaXmlUtils.SetCadastrarSecretaria(_cadastrarSecretaria);
            }
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

        private void TelaCadastrarSecretaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "cadastrar_secretaria")]
    public sealed class CadastrarSecretaria
    {
        public Secretaria Secretaria { get; set; }
    }
}