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
    public partial class TelaPesquisarPaciente : Form
    {
        private List<Paciente> pacientes;
        //? = Can be null or not
        private int? selectedRow;

        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";

        public TelaPesquisarPaciente()
        {
            InitializeComponent();
        }

        private void disableEditar()
        {
            btnAtualizar.Enabled = false;
            btnRemover.Enabled = false;

            maskedCell.Enabled = false;
            comboConvenio.Enabled = false;
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
            maskedCell.Clear();
            comboConvenio.SelectedIndex = 0;
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
            listViewPacientes.SelectedItems.Clear();
            txtFiltroNome.Focus();
        }

        private void enableEditar()
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            maskedCell.Enabled = true;
            comboConvenio.Enabled = true;
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {
                    ClinicaService service = new ClinicaService();
                    service.RemoverPaciente(pacientes[selectedRow.Value]);
                    MessageBox.Show(this, "Paciente removido com sucesso.");
                    pacientes.RemoveAt(selectedRow.Value);
                    listViewPacientes.Items.RemoveAt(selectedRow.Value);
                    disableEditar();
                }
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {
                    pacientes[selectedRow.Value].Convenio = ((BindingList<Convenio>)comboConvenio.DataSource).ElementAt(comboConvenio.SelectedIndex);
                    pacientes[selectedRow.Value].Nome = txtNome.Text;
                    pacientes[selectedRow.Value].CPF = maskedCPF.Text;
                    pacientes[selectedRow.Value].RG = txtRG.Text;
                    pacientes[selectedRow.Value].Contato = maskedCell.Text;
                    pacientes[selectedRow.Value].Dt_Nascimento = dateTimeDtNasc.Value;
                    pacientes[selectedRow.Value].Email = txtEmail.Text;
                    pacientes[selectedRow.Value].Endereco.CEP = maskedCEP.Text;
                    pacientes[selectedRow.Value].Endereco.Logradouro = txtLogradouro.Text;
                    pacientes[selectedRow.Value].Endereco.Complemento = txtComplemento.Text;
                    pacientes[selectedRow.Value].Endereco.Numero = txtNumero.Text;
                    pacientes[selectedRow.Value].Endereco.Bairro = txtBairro.Text;
                    pacientes[selectedRow.Value].Endereco.Cidade = txtCidade.Text;
                    pacientes[selectedRow.Value].Endereco.UF = comboUF.SelectedItem.ToString();
                    pacientes[selectedRow.Value].Endereco.Pais = txtPais.Text;
                    if (rbSolteiro.Checked)
                    {
                        pacientes[selectedRow.Value].Estado_Civil = rbSolteiro.Text;
                    }
                    else if (rbCasado.Checked)
                    {
                        pacientes[selectedRow.Value].Estado_Civil = rbCasado.Text;
                    }
                    else
                    {
                        pacientes[selectedRow.Value].Estado_Civil = rbViuvo.Text;
                    }

                    ClinicaService service = new ClinicaService();
                    service.AtualizarPaciente(pacientes[selectedRow.Value]);
                    MessageBox.Show("Paciente atualizado com sucesso!");
                    disableEditar();

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
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

            try
            {
                listViewPacientes.Items.Clear();
                ClinicaService service = new ClinicaService();

                pacientes = new List<Paciente>(service.ListarPaciente(new Paciente
                {
                    Nome = txtFiltroNome.Text,
                    CPF = maskedFiltroCPF.Text
                }));


                foreach (Paciente paciente in pacientes)
                {
                    ListViewItem linha = listViewPacientes.Items.Add(paciente.ID_Paciente.ToString());
                    linha.SubItems.Add(paciente.Nome);
                    linha.SubItems.Add(paciente.Convenio.Descricao);
                    linha.SubItems.Add(paciente.Contato);
                }

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

        private void TelaPesquisarPaciente_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();

            comboConvenio.DataSource = new BindingList<Convenio>(service.ListarConvenio(new Convenio()));
            comboConvenio.DisplayMember = "Descricao";
            txtPais.Text = "Brasil";
            txtPais.Enabled = false;
        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPacientes.SelectedItems.Count > 0)
            {
                selectedRow = listViewPacientes.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                #region Dados
                txtNome.Text = pacientes[selectedRow.Value].Nome;
                maskedCPF.Text = pacientes[selectedRow.Value].CPF;
                txtRG.Text = pacientes[selectedRow.Value].RG;
                maskedCell.Text = pacientes[selectedRow.Value].Contato;
                comboConvenio.SelectedIndex = pacientes[selectedRow.Value].Convenio.ID_Convenio - 1;
                dateTimeDtNasc.Value = pacientes[selectedRow.Value].Dt_Nascimento;
                txtEmail.Text = pacientes[selectedRow.Value].Email;
                switch (pacientes[selectedRow.Value].Estado_Civil)
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
                maskedCEP.Text = pacientes[selectedRow.Value].Endereco.CEP;
                txtLogradouro.Text = pacientes[selectedRow.Value].Endereco.Logradouro;
                txtNumero.Text = pacientes[selectedRow.Value].Endereco.Numero;
                txtComplemento.Text = pacientes[selectedRow.Value].Endereco.Complemento;
                txtBairro.Text = pacientes[selectedRow.Value].Endereco.Bairro;
                txtCidade.Text = pacientes[selectedRow.Value].Endereco.Cidade;
                comboUF.SelectedItem = pacientes[selectedRow.Value].Endereco.UF;
                txtPais.Text = pacientes[selectedRow.Value].Endereco.Pais;
                #endregion

                enableEditar();
            }
            else
            {
                selectedRow = null;
                disableEditar();
            }
        }
    }

}

