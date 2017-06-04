using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telamedico
{
    public partial class TelaCadastroMedico : Form
    {
        public TelaCadastroMedico()
        {
            InitializeComponent();
        }

        private void TelaCadastroMedico_Load(object sender, EventArgs e)
        {
            //comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();
            comboBox1.DataSource = new BindingList<Especialidade>(service.ListarEspecialidade(new Especialidade()));
            comboBox1.DisplayMember = "Descricao";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();

                medico.Especialidade = ((BindingList<Especialidade>)comboBox1.DataSource).ElementAt(comboBox1.SelectedIndex);

                medico.Nome = txtNome.Text;
                medico.CPF = maskedCPF.Text;
                medico.RG = txtRG.Text;
                medico.Contato = maskedCell.Text;
                medico.CRM = txtCRM.Text;
                medico.Dt_Nascimento = dateTimeDtNasc.Value;
                medico.Email = txtEmail.Text;
                medico.Endereco = new Endereco();
                medico.Endereco.CEP = maskedCEP.Text;
                medico.Endereco.Logradouro = txtLogradouro.Text;
                medico.Endereco.Complemento = txtComplemento.Text;
                medico.Endereco.Numero = txtNumero.Text;
                medico.Endereco.Bairro = txtBairro.Text;
                medico.Endereco.Cidade = txtCidade.Text;
                medico.Endereco.UF = comboUF.SelectedItem.ToString();
                medico.Endereco.Pais = txtPais.Text;
                if (rbSolteiro.Checked)
                {
                    medico.Estado_Civil = rbSolteiro.Text;
                }
                else if (rbCasado.Checked)
                {
                    medico.Estado_Civil = rbCasado.Text;
                }
                else
                {
                    medico.Estado_Civil = rbViuvo.Text;
                }

                ClinicaService service = new ClinicaService();
                service.CadastrarMedico(medico);
                MessageBox.Show(@"Médico atualizado com sucesso!");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

        }

        /*private void txtNome_Leave(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = txtNome.Text;

            ClinicaXmlUtils.Create();
            ClinicaXmlUtils.SetCadastrarMedico(medico);
        }*/
    }
}
