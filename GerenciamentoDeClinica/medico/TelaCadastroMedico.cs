using Biblioteca.classesBasicas;
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

namespace GerenciamentoDeClinicas.medico
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
    }
}
