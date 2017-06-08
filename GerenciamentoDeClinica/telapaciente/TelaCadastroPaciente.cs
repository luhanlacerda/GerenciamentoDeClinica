﻿using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telapaciente
{
    public partial class TelaCadastroPaciente : Form, IConsistenciaDados
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private CadastrarPaciente _cadastrarPaciente;

        public TelaCadastroPaciente()
        {
            InitializeComponent();
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
            maskedCell.Clear();
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbViuvo.Checked = false;
            dateTimeDtNasc.Value = DateTime.Now;
            comboConvenio.SelectedIndex = 0;
        }

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;
            ClinicaService service = new ClinicaService();
            comboConvenio.DataSource = new BindingList<Convenio>(service.ListarConvenio(new Convenio()));
            comboConvenio.DisplayMember = "Descricao";

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarPaciente = ClinicaXmlUtils.GetCadastrarPaciente();
            if (_cadastrarPaciente != null)
                CarregarEditar(_cadastrarPaciente.Paciente);
            else
                _cadastrarPaciente = new CadastrarPaciente() {Paciente = new Paciente()};

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ValidarCamposString();
                _cadastrarPaciente.Paciente = GetPaciente();

                ClinicaService service = new ClinicaService();
                service.CadastrarPaciente(_cadastrarPaciente.Paciente);
                MessageBox.Show(@"Paciente cadastrado com sucesso!");
                LimparCampos();
                txtNome.Focus();
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
            _cadastrarPaciente.Paciente = GetPaciente();

            if (!_savedCadastrar.Equals(ClinicaXmlUtils.ToXml(_cadastrarPaciente)))
            {
                //altera o cliente para um novo
                _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarPaciente);

                ClinicaXmlUtils.SetCadastrarPaciente(_cadastrarPaciente);
            }
        }

        //Adquirir valor do combobox Convenio da thread principal
        private Convenio GetConvenio()
        {
            Convenio convenio = null;

            Invoke(new MethodInvoker(delegate()
            {
                if (!comboConvenio.IsDisposed)
                    convenio = ((BindingList<Convenio>) comboConvenio.DataSource)
                        .ElementAt(comboConvenio.SelectedIndex);
            }));
            return convenio;
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

            Invoke(new MethodInvoker(delegate()
            {
                if (!comboUF.IsDisposed) text = comboUF.SelectedItem.ToString();
            }));
            return text;
        }

        private Paciente GetPaciente()
        {
            return new Paciente
            {
                CPF = maskedCPF.Text,
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
                Email = txtEmail.Text,
                Estado_Civil = GetEstadoCivil()
            };
        }

        private void TelaCadastroPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }


        void ValidarCamposString()
        {
            //Nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show(this, @"Informe o nome da paciente");
            }

            //CPF
            if (string.IsNullOrEmpty(maskedCPF.Text))
            {
                MessageBox.Show(this, @"Informe o CPF da paciente");
            }

            //RG
            if (string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show(this, @"Informe o RG da paciente");
            }

            //Contato
            if (string.IsNullOrEmpty(maskedCell.Text))
            {
                MessageBox.Show(this, @"Informe o número de contato da paciente");
            }

            //Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(this, @"Informe o email da paciente");
            }

            //CEP
            if (string.IsNullOrEmpty(maskedCEP.Text))
            {
                MessageBox.Show(this, @"Informe o CEP da paciente");
            }

            //Logradouro
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                MessageBox.Show(this, @"Informe o logradouro da paciente");
            }

            //Numero
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show(this, @"Informe o numero do endereço da paciente");
            }

            //Complemento
            if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show(this, @"Informe o complemento da paciente");
            }

            //Bairro
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show(this, @"Informe o bairro da paciente");
            }

            //Cidade
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show(this, @"Informe a cidade da paciente");
            }

            //País
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show(this, @"Informe o país da paciente");
            }
        }


    }


    [XmlRoot(ElementName = "cadastrar_paciente")]
    public sealed class CadastrarPaciente
    {
        public Paciente Paciente { get; set; }
    }
}




