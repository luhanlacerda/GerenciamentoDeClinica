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

namespace GerenciamentoDeClinica.telamedico
{
    public partial class TelaPesquisarMedico : Form
    {
        private List<Medico> medicos;
        private int? selectedRow;

        public TelaPesquisarMedico()
        {
            InitializeComponent();
        }

        private void TelaPesquisarMedico_Load(object sender, EventArgs e)
        {
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();
            comboEspecialidade.DataSource = new BindingList<Especialidade>(service.ListarEspecialidade(new Especialidade()));
            comboEspecialidade.DisplayMember = "Descricao";
        }

        private void enableEditar()
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            maskedCell.Enabled = true;
            comboEspecialidade.Enabled = true;
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

            maskedCell.Enabled = false;
            comboEspecialidade.Enabled = false;
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
            txtCRM.Clear();
            comboEspecialidade.SelectedIndex = 0;
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
            listMedicos.SelectedItems.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                listMedicos.Items.Clear();

                ClinicaService service = new ClinicaService();
                medicos = new List<Medico>(service.ListarMedico(new Medico
                {
                    Nome = txtPesqNome.Text,
                    CRM = txtPesqCRM.Text
                }));
                foreach (Medico medico in medicos)
                {
                    ListViewItem linha = listMedicos.Items.Add(medico.ID_Medico.ToString());
                    linha.SubItems.Add(medico.Nome);
                    linha.SubItems.Add(medico.CRM);
                }

                disableEditar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {
                    medicos[selectedRow.Value].Especialidade = ((BindingList<Especialidade>)comboEspecialidade.DataSource).ElementAt(comboEspecialidade.SelectedIndex);
                    medicos[selectedRow.Value].Nome = txtNome.Text;
                    medicos[selectedRow.Value].CPF = maskedCPF.Text;
                    medicos[selectedRow.Value].RG = txtRG.Text;
                    medicos[selectedRow.Value].Contato = maskedCell.Text;
                    medicos[selectedRow.Value].CRM = txtCRM.Text;
                    medicos[selectedRow.Value].Dt_Nascimento = dateTimeDtNasc.Value;
                    medicos[selectedRow.Value].Email = txtEmail.Text;
                    medicos[selectedRow.Value].Endereco.CEP = maskedCEP.Text;
                    medicos[selectedRow.Value].Endereco.Logradouro = txtLogradouro.Text;
                    medicos[selectedRow.Value].Endereco.Complemento = txtComplemento.Text;
                    medicos[selectedRow.Value].Endereco.Numero = txtNumero.Text;
                    medicos[selectedRow.Value].Endereco.Bairro = txtBairro.Text;
                    medicos[selectedRow.Value].Endereco.Cidade = txtCidade.Text;
                    medicos[selectedRow.Value].Endereco.UF = comboUF.SelectedItem.ToString();
                    medicos[selectedRow.Value].Endereco.Pais = txtPais.Text;
                    if (rbSolteiro.Checked)
                    {
                        medicos[selectedRow.Value].Estado_Civil = rbSolteiro.Text;
                    }
                    else if (rbCasado.Checked)
                    {
                        medicos[selectedRow.Value].Estado_Civil = rbCasado.Text;
                    }
                    else
                    {
                        medicos[selectedRow.Value].Estado_Civil = rbViuvo.Text;
                    }

                    ClinicaService service = new ClinicaService();
                    service.AtualizarMedico(medicos[selectedRow.Value]);
                    MessageBox.Show("Médico atualizado com sucesso!");
                    disableEditar();
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
                    ClinicaService service = new ClinicaService();
                    service.RemoverMedico(medicos[selectedRow.Value]);
                    MessageBox.Show("Médico removido com sucesso!");
                    medicos.RemoveAt(selectedRow.Value);
                    listMedicos.Items.RemoveAt(selectedRow.Value);
                    disableEditar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMedicos.SelectedItems.Count > 0)
            {
                selectedRow = listMedicos.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                #region Colocar dados
                txtNome.Text = medicos[selectedRow.Value].Nome;
                maskedCPF.Text = medicos[selectedRow.Value].CPF;
                txtRG.Text = medicos[selectedRow.Value].RG;
                maskedCell.Text = medicos[selectedRow.Value].Contato;
                txtCRM.Text = medicos[selectedRow.Value].CRM;
                comboEspecialidade.SelectedIndex = medicos[selectedRow.Value].Especialidade.ID_Especialidade - 1;
                dateTimeDtNasc.Value = medicos[selectedRow.Value].Dt_Nascimento;
                txtEmail.Text = medicos[selectedRow.Value].Email;
                switch (medicos[selectedRow.Value].Estado_Civil)
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
                maskedCEP.Text = medicos[selectedRow.Value].Endereco.CEP;
                txtLogradouro.Text = medicos[selectedRow.Value].Endereco.Logradouro;
                txtNumero.Text = medicos[selectedRow.Value].Endereco.Numero;
                txtComplemento.Text = medicos[selectedRow.Value].Endereco.Complemento;
                txtBairro.Text = medicos[selectedRow.Value].Endereco.Bairro;
                txtCidade.Text = medicos[selectedRow.Value].Endereco.Cidade;
                comboUF.SelectedItem = medicos[selectedRow.Value].Endereco.UF;
                txtPais.Text = medicos[selectedRow.Value].Endereco.Pais;
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
