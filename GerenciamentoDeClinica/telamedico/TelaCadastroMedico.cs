using Biblioteca.classesBasicas;
using Biblioteca.medico;
using Biblioteca.utils;
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

namespace GerenciamentoDeClinicas.telamedico
{
    public partial class TelaCadastroMedico : Form
    {
        public TelaCadastroMedico()
        {
            InitializeComponent();
        }

        private void TelaCadastroMedico_Load(object sender, EventArgs e)
        {
            comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            if (maskedCEP.MaskFull)
            {
                Endereco endereco = CepUtils.PegarEndereco(maskedCEP.Text);
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

                medico.Especialidade = new Biblioteca.especialidade.Especialidade { ID_Especialidade = 1 };

                medico.ID_Medico = Convert.ToInt32(txtID.Text);
                medico.Nome = txtNome.Text;
                medico.CPF = maskedCPF.Text;
                medico .RG = txtRG.Text;
                medico.Contato = maskedCell.Text;
                medico.CRM = txtCRM.Text;
                medico.Especialidade.ID_Especialidade = Convert.ToInt32(txtEspecialidade.Text);
                medico.Dt_Nascimento= dateTimeDtNasc.Value;
                medico.Email = txtEmail.Text;
                medico.Endereco.CEP = maskedCEP.Text;
                medico.Endereco.Logradouro = txtLogradouro.Text;
                medico.Endereco.Complemento = txtComplemento.Text;
                medico.Endereco.Numero = txtNumero.Text;
                medico.Endereco.Bairro = txtBairro.Text;
                medico.Endereco.Cidade = txtCidade.Text;
                medico.Endereco.UF = comboUF.SelectedItem.ToString();
                medico.Endereco.Pais = txtPais.Text;
                RadioButton radio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radio.Name == rbSolteiro.Name)
                {
                    medico.Estado_Civil = rbSolteiro.Text;
                } else if (radio.Name == rbCasado.Name)
                {
                    medico.Estado_Civil = rbCasado.Text;
                } else
                {
                    medico.Estado_Civil = rbViuvo.Text;
                }

                new NegocioMedico().Cadastrar(medico);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = txtNome.Text;

            ClinicaXMLUtils.Create();
            ClinicaXMLUtils.SetCadastrarMedico(medico);
        }
    }
}
