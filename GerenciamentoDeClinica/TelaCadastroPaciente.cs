using Biblioteca.paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica
{
    public partial class TelaCadastroPaciente : Form
    {
        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente()
                {
                    Nome = textBoxNome.Text,
                    Cpf = maskedTextBoxCPF.Text,
                    Rg = textBoxRG.Text,
                    Contato = textBoxContato.Text,
                    Logradouro = textBoxLogradouro.Text,
                    Numero = textBoxNumero.Text,
                    Complemento = textBoxComplemento.Text,
                    Bairro = textBoxBairro.Text,
                    Cidade = textBoxCidade.Text,
                    Uf = comboBoxUF.SelectedItem.ToString(),
                    Pais = comboBoxPais.SelectedItem.ToString(),
                };
                paciente.Convenio.Id_convenio = 1;

                PacienteBD conn = new PacienteBD();
                conn.Cadastrar(paciente);
                MessageBox.Show("Paciente cadastrado com sucesso!");

                textBoxNome.Text = "";
                maskedTextBoxCPF.Text = "";
                textBoxRG.Text = "";
                textBoxContato.Text = "";
                textBoxLogradouro.Text = "";
                textBoxNumero.Text = "";
                textBoxComplemento.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                comboBoxPais.Text = "";
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
