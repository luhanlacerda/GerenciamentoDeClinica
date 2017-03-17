using GerenciamentoDeClinicas;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        TelaCadastroMedico TelaCadastrarMedico;
        private void cadastrarMedicos_Click(object sender, EventArgs e)
        {
            if (TelaCadastrarMedico == null)
            {
                TelaCadastrarMedico = new TelaCadastroMedico();
                TelaCadastrarMedico.MdiParent = this;
                TelaCadastrarMedico.FormClosed += TelaCadastrarMedico_FormClosed;
                TelaCadastrarMedico.Show();
            }
            else
            {
                TelaCadastrarMedico.Activate();
            }
        }

        private void TelaCadastrarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaCadastrarMedico = null;
            //throw new NotImplementedException();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        TelaTesteConexaoSql TelaTestarConexaoSql;
        private void testarConexãoBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaTestarConexaoSql == null)
            {
                TelaTestarConexaoSql = new TelaTesteConexaoSql();
                TelaTestarConexaoSql.MdiParent = this;
                TelaTestarConexaoSql.FormClosed += TelaTestarConexaoSql_FormClosed;
                TelaTestarConexaoSql.Show();
            }
            else
            {
                TelaTestarConexaoSql.Activate();
            }
        }

        private void TelaTestarConexaoSql_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaCadastrarMedico = null;
            //throw new NotImplementedException();
        }

        TelaCadastroPaciente TelaCadastrarPaciente;
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaCadastrarPaciente == null)
            {
                TelaCadastrarPaciente = new TelaCadastroPaciente();
                TelaCadastrarPaciente.MdiParent = this;
                TelaCadastrarPaciente.FormClosed += TelaCadastrarPacienteSql_FormClosed;
                TelaCadastrarPaciente.Show();
            }
            else
            {
                TelaCadastrarPaciente.Activate();
            }
        }

        private void TelaCadastrarPacienteSql_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaCadastrarPaciente = null;
            //throw new NotImplementedException();
        }
    }
}

