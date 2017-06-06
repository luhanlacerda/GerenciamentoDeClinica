using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telasecretaria
{
    public partial class TelaCadastrarSecretaria : Form
    {
        public TelaCadastrarSecretaria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposString();
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
                secretaria.Contato = maskedContato.Text;
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
                maskedContato.Clear();

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

        void ValidarCamposString()
        {
            //Nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show(this, @"Informe o nome da secretária");
            }

            //CPF
            if (string.IsNullOrEmpty(maskedCPF.Text))
            {
                MessageBox.Show(this, @"Informe o CPF da secretária");
            }

            //RG
            if (string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show(this, @"Informe o RG da secretária");
            }

            //Contato
            if (string.IsNullOrEmpty(maskedContato.Text))
            {
                MessageBox.Show(this, @"Informe o número de contato da secretária");
            }

            //Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(this, @"Informe o email da secretária");
            }

            //CEP
            if (string.IsNullOrEmpty(maskedCEP.Text))
            {
                MessageBox.Show(this, @"Informe o CEP da secretária");
            }

            //Logradouro
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                MessageBox.Show(this, @"Informe o logradouro da secretária");
            }

            //Numero
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show(this, @"Informe o numero do endereço da secretária");
            }

            //Complemento
            if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show(this, @"Informe o complemento da secretária");
            }

            //Bairro
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show(this, @"Informe o bairro da secretária");
            }

            //Cidade
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show(this, @"Informe a cidade da secretária");
            }

            //País
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show(this, @"Informe o país da secretária");
            }
        }
    }
}