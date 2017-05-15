using Biblioteca.classesBasicas;
using Biblioteca.paciente;
using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.paciente
{
    public partial class TelaCadastroPaciente : Form
    {
        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {
            comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void clearAll(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

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

        private void maskedCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
