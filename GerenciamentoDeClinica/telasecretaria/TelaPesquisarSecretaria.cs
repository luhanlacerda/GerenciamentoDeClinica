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
    public partial class TelaPesquisarSecretaria : Form
    {

        private List<Secretaria> secretarias;
        //? = podendo ser nulo ou não
        private int? selectedRow;

        public TelaPesquisarSecretaria()
        {
            InitializeComponent();
        }

        private void TelaPesquisarSecretaria_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;
            //savedSecretaria = new Secretaria();

        }

        private void enableEditar()
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

        private void disableEditar()
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
                secretarias = new List<Secretaria>(service.ListarSecretaria(new Secretaria
                {
                    ID_Secretaria = 0,
                    Nome = txtNomePesq.Text,
                    CPF = maskedCPFPesq.Text
                }));

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
                selectedRow = listViewSecretarias.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                #region Colocando Dados na Tela
                txtNome.Text = secretarias[selectedRow.Value].Nome;
                maskedCPF.Text = secretarias[selectedRow.Value].CPF;
                txtRG.Text = secretarias[selectedRow.Value].RG;
                maskedContato.Text = secretarias[selectedRow.Value].Contato;
                dateTimeDtNasc.Value = secretarias[selectedRow.Value].Dt_Nascimento;
                txtEmail.Text = secretarias[selectedRow.Value].Email;
                switch (secretarias[selectedRow.Value].Estado_Civil)
                {
                    case "Solteiro(a)":
                        rbSolteiro.Checked = true;
                        break;
                    case "Casado(a)":
                        rbCasado.Checked = true;
                        break;
                    case "Viúvo(a)":
                        rbViuvo.Checked = true;
                        break;
                }
                maskedCEP.Text = secretarias[selectedRow.Value].Endereco.CEP;
                txtLogradouro.Text = secretarias[selectedRow.Value].Endereco.Logradouro;
                txtNumero.Text = secretarias[selectedRow.Value].Endereco.Numero;
                txtComplemento.Text = secretarias[selectedRow.Value].Endereco.Complemento;
                txtBairro.Text = secretarias[selectedRow.Value].Endereco.Bairro;
                txtCidade.Text = secretarias[selectedRow.Value].Endereco.Cidade;
                comboUF.Text = secretarias[selectedRow.Value].Endereco.UF;
                txtPais.Text = secretarias[selectedRow.Value].Endereco.Pais;
                #endregion

                enableEditar();
            }
            else
            {
                selectedRow = null;
                disableEditar();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {

                    secretarias[selectedRow.Value].Nome = txtNome.Text;
                    secretarias[selectedRow.Value].CPF = maskedCPF.Text;
                    secretarias[selectedRow.Value].RG = txtRG.Text;
                    secretarias[selectedRow.Value].Contato = maskedContato.Text;
                    secretarias[selectedRow.Value].Dt_Nascimento = dateTimeDtNasc.Value;
                    secretarias[selectedRow.Value].Email = txtEmail.Text;
                    if (rbSolteiro.Checked)
                    {
                        secretarias[selectedRow.Value].Estado_Civil = rbSolteiro.Text;
                    }
                    else if (rbCasado.Checked)
                    {
                        secretarias[selectedRow.Value].Estado_Civil = rbCasado.Text;
                    }
                    else
                    {
                        secretarias[selectedRow.Value].Estado_Civil = rbViuvo.Text;
                    }
                    secretarias[selectedRow.Value].Endereco.CEP = maskedCEP.Text;
                    secretarias[selectedRow.Value].Endereco.Logradouro = txtLogradouro.Text;
                    secretarias[selectedRow.Value].Endereco.Numero = txtNumero.Text;
                    secretarias[selectedRow.Value].Endereco.Complemento = txtComplemento.Text;
                    secretarias[selectedRow.Value].Endereco.Bairro = txtBairro.Text;
                    secretarias[selectedRow.Value].Endereco.Cidade = txtCidade.Text;
                    secretarias[selectedRow.Value].Endereco.UF = comboUF.Text;
                    secretarias[selectedRow.Value].Endereco.Pais = txtPais.Text;

                    ClinicaService service = new ClinicaService();
                    service.AtualizarSecretaria(secretarias[selectedRow.Value]);
                    MessageBox.Show("Secretária atualizada com sucesso!");

                    listViewSecretarias.Items.Clear();
                    secretarias = new List<Secretaria>(service.ListarSecretaria(new Secretaria
                    {
                        ID_Secretaria = 0,
                        Nome = txtNomePesq.Text,
                        CPF = maskedCPFPesq.Text
                    }));

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
                    MessageBox.Show(this, ex.Message);
                }

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {
                    var confirmarExclusao = MessageBox.Show("Deseja remover a secretária?", "Confirmação", MessageBoxButtons.YesNo);
                    if (confirmarExclusao == DialogResult.Yes)
                    {

                        ClinicaService service = new ClinicaService();
                        service.RemoverSecretaria(secretarias[selectedRow.Value]);
                        MessageBox.Show("Secretária removida com sucesso!");
                        secretarias.RemoveAt(selectedRow.Value);
                        listViewSecretarias.Items.RemoveAt(selectedRow.Value);
                        disableEditar();
                    }
                    else
                    {
                        txtNomePesq.Focus();
                        disableEditar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
