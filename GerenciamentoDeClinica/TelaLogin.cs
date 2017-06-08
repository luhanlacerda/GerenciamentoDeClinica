using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeClinica.localhost;
using System.Net;

namespace GerenciamentoDeClinica
{
    public partial class TelaLogin : Form
    {
        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";


        public TelaLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button1_Click(object sender, EventArgs e)

        {
            #region Validações dos campos
            var username = txtUser.Text;
            var password = txtPassword.Text;
            /*if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show(@"Por favor, digite seu nome de usuário.");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"Por favor, digite sua senha.");
                txtPassword.Focus();
                return;
            }*/
            #endregion

            try
            {
             /*if ( )
               {

                ClinicaService service = new ClinicaService();
                Usuario usuario = new Usuario();
                usuario.Nome = username;
                usuario.Senha = password;
                telaMain();

                MessageBox.Show(@"Login efetuado com sucesso.");
                   telaMain();
               }
               else
               {
                   MessageBox.Show(this, @"Dados de acesso inválidos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
               }*/
                telaMain();

            }
            catch (WebException)
            {
                MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        void telaMain()
        {
            TelaPrincipal telaMain = new TelaPrincipal();
            this.Hide();
            telaMain.ShowDialog();
            this.Close();
        }
    }
}
