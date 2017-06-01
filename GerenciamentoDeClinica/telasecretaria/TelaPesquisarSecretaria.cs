using GerenciamentoDeClinica.localhost;
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
    public partial class TelaPesquisarSecretaria : Form
    {

        private Secretaria[] secretarias;
        ClinicaService service = new ClinicaService();

        public TelaPesquisarSecretaria()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewSecretarias.Items.Clear();
            try
            {

                secretarias = service.ListarSecretaria(new Secretaria
                {
                    ID_Secretaria = 0,
                    Nome = txtNomePesq.Text,
                    CPF = maskedCPFPesq.Text
                });

                foreach (Secretaria secretaria in secretarias)
                {
                    ListViewItem linha = listViewSecretarias.Items.Add(secretaria.ID_Secretaria.ToString());
                    linha.SubItems.Add(secretaria.Nome);
                    linha.SubItems.Add(secretaria.CPF);
                    linha.SubItems.Add(secretaria.Contato);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void listViewSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSecretarias.SelectedItems.Count > 0)
            {
                int selected = listViewSecretarias.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                txtNome.Text = secretarias[selected].Nome;
                maskedCPF.Text = secretarias[selected].CPF;
                txtRG.Text = secretarias[selected].RG;
                maskedContato.Text = secretarias[selected].Contato;
                dateTimeDtNasc.Value = secretarias[selected].Dt_Nascimento;
                txtEmail.Text = secretarias[selected].Email;
                switch (secretarias[selected].Estado_Civil)
                {
                    case "Solteiro(a)":
                        rbSolteiro.Checked = true;
                        break;
                    case "Casado(a)":
                        rbCasado.Checked = true;
                        break;
                    case "Viuvo(a)":
                        rbViuvo.Checked = true;
                        break;
                }
                maskedCEP.Text = secretarias[selected].Endereco.CEP;
                txtLogradouro.Text = secretarias[selected].Endereco.Logradouro;
                txtNumero.Text = secretarias[selected].Endereco.Numero;
                txtComplemento.Text = secretarias[selected].Endereco.Complemento;
                txtBairro.Text = secretarias[selected].Endereco.Bairro;
                txtCidade.Text = secretarias[selected].Endereco.Cidade;
                comboUF.Text = secretarias[selected].Endereco.UF;
                txtPais.Text = secretarias[selected].Endereco.Pais;

                btnAtualizar.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listViewSecretarias.SelectedItems.Count > 0)
            {
                int selected = listViewSecretarias.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                secretarias[selected].Nome = txtNome.Text;
                secretarias[selected].CPF = maskedCPF.Text;
                secretarias[selected].RG = txtRG.Text;
                secretarias[selected].Contato = maskedContato.Text;
                secretarias[selected].Dt_Nascimento = dateTimeDtNasc.Value;
                secretarias[selected].Email = txtEmail.Text;
                switch (secretarias[selected].Estado_Civil)
                {
                    case "Solteiro(a)":
                        rbSolteiro.Checked = true;
                        break;
                    case "Casado(a)":
                        rbCasado.Checked = true;
                        break;
                    case "Viuvo(a)":
                        rbViuvo.Checked = true;
                        break;
                }
                secretarias[selected].Endereco.CEP = maskedCEP.Text;
                secretarias[selected].Endereco.Logradouro = txtLogradouro.Text;
                secretarias[selected].Endereco.Numero = txtNumero.Text;
                secretarias[selected].Endereco.Complemento = txtComplemento.Text;
                secretarias[selected].Endereco.Bairro = txtBairro.Text;
                secretarias[selected].Endereco.Cidade = txtCidade.Text;
                secretarias[selected].Endereco.UF = comboUF.Text;
                secretarias[selected].Endereco.Pais = txtPais.Text;

                try
                {
                    service.AtualizarSecretaria(secretarias[selected]);
                    MessageBox.Show("Secretária atualizada com sucesso!");

                    listViewSecretarias.Items.Clear();
                    secretarias = service.ListarSecretaria(new Secretaria
                    {
                        ID_Secretaria = 0,
                        Nome = txtNomePesq.Text,
                        CPF = maskedCPFPesq.Text
                    });

                    foreach (Secretaria listaSecretarias in secretarias)
                    {
                        ListViewItem linha = listViewSecretarias.Items.Add(listaSecretarias.ID_Secretaria.ToString());
                        linha.SubItems.Add(listaSecretarias.Nome);
                        linha.SubItems.Add(listaSecretarias.CPF);
                        linha.SubItems.Add(listaSecretarias.Contato);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            /*
            btnPesquisar.Enabled = false;
            txtNomePesq.Enabled = false;
            maskedPesqCPF.Enabled = false;
            */

            /*
            btnPesquisar.Enabled = true;
            txtNomePesq.Enabled = true;
            maskedPesqCPF.Enabled = true;
            btnRemover.Enabled = false;
            btnAtualizar.Enabled = false;

            maskedCell.Enabled = false;
            txtEmail.Enabled = false;
            rbSolteiro.Enabled = false;
            rbCasado.Enabled = false;
            rbViuvo.Enabled = false;
            txtBairro.Enabled = false;
            maskedCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            comboPais.Enabled = false;
            txtCidade.Enabled = false;
            comboUF.Enabled = false;
            */

        }
    }
}
