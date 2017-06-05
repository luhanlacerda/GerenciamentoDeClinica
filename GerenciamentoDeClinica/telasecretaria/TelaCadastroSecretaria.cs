using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telasecretaria
{
    public partial class TelaCadastroSecretaria : Form
    {
        //private Thread _threadSalvarDados;
        //private string _savedCadastrar = "";
        //private CadastrarSecretaria _cadastrarSecretaria;

        public TelaCadastroSecretaria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Secretaria secretaria = new Secretaria();

                secretaria.Nome = txtNome.Text;
                secretaria.RG = txtRG.Text;
                secretaria.CPF = maskedCPF.Text;
                secretaria.Email = txtEmail.Text;
                secretaria.Endereco = new Endereco();
                secretaria.Endereco.Logradouro = txtLogradouro.Text;
                secretaria.Endereco.Numero = txtNumero.Text;
                secretaria.Endereco.Complemento = txtComplemento.Text;
                secretaria.Endereco.Bairro = txtBairro.Text;
                secretaria.Endereco.CEP = maskedCEP.Text;
                secretaria.Endereco.Cidade = txtCidade.Text;
                secretaria.Endereco.UF = comboUF.Text;
                secretaria.Endereco.Pais = txtPais.Text;
                if (rbCasado.Checked == true)
                {
                    secretaria.Estado_Civil = rbCasado.Text;
                }
                else if (rbViuvo.Checked == true)
                {
                    secretaria.Estado_Civil = rbViuvo.Text;
                }
                else
                {
                    secretaria.Estado_Civil = rbSolteiro.Text;
                }
                secretaria.Contato = maskedCell.Text;
                secretaria.Dt_Nascimento = dateTimeDtNasc.Value;

                ClinicaService service = new ClinicaService();
                service.CadastrarSecretaria(secretaria);
                MessageBox.Show("Secretária cadastrada com sucesso!");

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
                maskedCell.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void TelaCadastrarSecretaria_Load(object sender, EventArgs e)
        {
            comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
            txtPais.Text = "Brasil";
            txtPais.Enabled = false;

            /*
            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarSecretaria = ClinicaXmlUtils.GetCadastrarSecretaria();
            if (_cadastrarSecretaria != null)
                CarregarEditar(_cadastrarSecretaria.Secretaria);
            else
                _cadastrarSecretaria = new CadastrarSecretaria() { Secretaria = new Secretaria() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
            */
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

        /*
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
                     //altera o cliente para um novo
                     _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarSecretaria);

                     ClinicaXmlUtils.SetCadastrarSecretaria(_cadastrarSecretaria);
                 }
             }
             */
        [XmlRoot(ElementName = "cadastrar_secretaria")]
        public sealed class CadastrarSecretaria
        {
            public Secretaria Secretaria { get; set; }
        }
        
    }
}