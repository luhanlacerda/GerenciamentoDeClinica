using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telapaciente
{
    public partial class TelaPesquisarPaciente : Form
    {
        public TelaPesquisarPaciente()
        {
            InitializeComponent();
        }

        void enablePesquisar()
        {
            btnPesquisar.Enabled = false;
            btnNovaBusca.Enabled = true;
            txtNomePesq.Enabled = false;
            maskedPesqCPF.Enabled = false;
            btnEditar.Enabled = true;
        }

        void enableNovaBusca()
        {
            btnNovaBusca.Enabled = false;
            btnPesquisar.Enabled = true;
            txtNomePesq.Enabled = true;
            maskedPesqCPF.Enabled = true;
            btnEditar.Enabled = false;
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
        }

        void enableEditar()
        {
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;

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

        void enableAtualizar()
        {
            btnAtualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnNovaBusca.Enabled = true;

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
        }

        void enableRemover()
        {
            btnAtualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnNovaBusca.Enabled = true;

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
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            enableRemover();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            enableAtualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enableEditar();
        }

        private void btnNovaBusca_Click(object sender, EventArgs e)
        {
            enableNovaBusca();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            enablePesquisar();
        }
    }
}
