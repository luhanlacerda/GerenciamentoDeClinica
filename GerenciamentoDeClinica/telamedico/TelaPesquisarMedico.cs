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

        private void enablePesquisar()
        {
            btnPesquisar.Enabled = false;
            btnNovaBusca.Enabled = true;
            txtPesqNome.Enabled = false;
            txtPesqCRM.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void enableNovaBusca()
        {
            btnNovaBusca.Enabled = false;
            btnPesquisar.Enabled = true;
            txtPesqNome.Enabled = true;
            txtPesqCRM.Enabled = true;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnAtualizar.Enabled = false;

            maskedCell.Enabled = false;
            txtCRM.Enabled = false;
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
            comboPais.Enabled = false;
            txtCidade.Enabled = false;
            comboUF.Enabled = false;
        }

        private void enableEditar()
        {
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

            txtCRM.Enabled = false;
            comboEspecialidade.Enabled = false;
            txtNome.Enabled = false;
            maskedCPF.Enabled = false;
            txtRG.Enabled = false;
            maskedCell.Enabled = true;
            dateTimeDtNasc.Enabled = false;
            txtEmail.Enabled = true;
            rbSolteiro.Enabled = true;
            rbCasado.Enabled = true;
            rbViuvo.Enabled = true;

            txtBairro.Enabled = true;
            maskedCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            comboPais.Enabled = true;
            txtCidade.Enabled = true;
            comboUF.Enabled = true;
        }

        private void enableAtualizar()
        {
            btnAtualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnNovaBusca.Enabled = true;

            maskedCell.Enabled = false;
            txtCRM.Enabled = false;
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
            comboPais.Enabled = false;
            txtCidade.Enabled = false;
            comboUF.Enabled = false;
        }

        private void enableRemover()
        {
            btnAtualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnNovaBusca.Enabled = true;

            maskedCell.Enabled = false;
            txtCRM.Enabled = false;
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
            comboPais.Enabled = false;
            txtCidade.Enabled = false;
            comboUF.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enablePesquisar();

            try
            {
                ClinicaService service = new ClinicaService();

                Medico filtro = new Medico
                {
                    Nome = txtPesqNome.Text.Trim(),
                    CRM = txtPesqCRM.Text.Trim()
                };

                Medico[] medicos = service.ListarMedico(filtro);

                //service.CadastrarMedico(medico);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnNovaBusca_Click(object sender, EventArgs e)
        {
            enableNovaBusca();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            enableAtualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enableEditar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            enableRemover();
        }
    }
}
