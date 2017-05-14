using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.secretaria
{
    public partial class TelaPesquisarSecretaria : Form
    {
        public TelaPesquisarSecretaria()
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
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            maskedCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            comboPais.Enabled = false;
            comboCidade.Enabled = false;
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

            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            maskedCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            comboPais.Enabled = true;
            comboCidade.Enabled = true;
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
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            maskedCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            comboPais.Enabled = false;
            comboCidade.Enabled = false;
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
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            maskedCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            comboPais.Enabled = false;
            comboCidade.Enabled = false;
            comboUF.Enabled = false;
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void maskedCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedCell_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimeDtNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbSolteiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbViuvo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            enablePesquisar();

        }

        private void btnNovaBusca_Click(object sender, EventArgs e)
        {
            enableNovaBusca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enableEditar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            enableAtualizar();  
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            enableRemover();
        }
    }
}
