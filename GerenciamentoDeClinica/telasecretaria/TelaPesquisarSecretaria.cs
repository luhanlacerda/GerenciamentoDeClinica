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
        ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarSecretaria()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewSecretarias.Items.Clear();
            try
            {
                Secretaria[] secretarias = clinicaService.ListarSecretaria(new Secretaria
                {
                    ID_Secretaria = 0,
                    Nome = txtNomePesq.Text,
                    CPF = maskedCPFPesq.Text
                });

                foreach (Secretaria listaSecretaria in secretarias)
                {
                    ListViewItem linha = listViewSecretarias.Items.Add(listaSecretaria.ID_Secretaria.ToString());
                    linha.SubItems.Add(listaSecretaria.Nome.ToString());
                    linha.SubItems.Add(listaSecretaria.CPF.ToString());
                    linha.SubItems.Add(listaSecretaria.Contato.ToString());
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
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
