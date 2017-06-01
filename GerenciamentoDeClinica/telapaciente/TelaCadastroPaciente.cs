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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telapaciente
{
    public partial class TelaCadastroPaciente : Form
    {
        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";

        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        #region clearFomr
        void ClearTextBoxs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        #endregion

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;
            ClinicaService service = new ClinicaService();
            comboConvenio.DataSource = new BindingList<Convenio>(service.ListarConvenio(new Convenio()));
            comboConvenio.DisplayMember = "Descricao";
            txtPais.Text = "Brasil";
            txtPais.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                
                paciente.Nome = txtNome.Text;
                paciente.CPF = maskedCPF.Text;
                paciente.RG = txtRG.Text;
                paciente.Contato = maskedCell.Text;
                paciente.Dt_Nascimento = dateTimeDtNasc.Value;
                paciente.Email = txtEmail.Text;
                paciente.Endereco = new Endereco();
                paciente.Endereco.CEP = maskedCEP.Text;
                paciente.Endereco.Logradouro = txtLogradouro.Text;
                paciente.Endereco.Complemento = txtComplemento.Text;
                paciente.Endereco.Numero = txtNumero.Text;
                paciente.Endereco.Bairro = txtBairro.Text;
                paciente.Endereco.Cidade = txtCidade.Text;
                paciente.Endereco.UF = comboUF.SelectedItem.ToString();
                paciente.Endereco.Pais = txtPais.Text;
                if (rbCasado.Checked == true)
                {
                    paciente.Estado_Civil = rbCasado.Text;
                }
                else if (rbViuvo.Checked == true)
                {
                    paciente.Estado_Civil = rbViuvo.Text;
                }
                else
                {
                    paciente.Estado_Civil = rbSolteiro.Text;
                }

                ClinicaService service = new ClinicaService();
                service.CadastrarPaciente(paciente);
                MessageBox.Show("Paciente cadastrado com sucesso!");
                ClearTextBoxs();
                txtNome.Focus();
            }
            catch (WebException)
            {
                MessageBox.Show(ERROR_WEBSERVICE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
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
    }
}
