using Biblioteca.convenio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telaconvenio
{
    public partial class TelaCadastroConvenio : Form
    {
        public TelaCadastroConvenio()
        {
            InitializeComponent();
        }


        void ClearTextBoxs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Convenio convenio = new Convenio();

                convenio.Descricao = txtDescricao.Text; 

                new ConvenioBD().Cadastrar(convenio);
                MessageBox.Show("Convenio cadastrado com sucesso.");
                ClearTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
