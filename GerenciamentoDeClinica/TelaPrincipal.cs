using GerenciamentoDeClinica.telaconsulta;
using GerenciamentoDeClinica.telaconvenio;
using GerenciamentoDeClinica.telaespecialidade;
using GerenciamentoDeClinica.telamedico;
using GerenciamentoDeClinica.telapaciente;
using GerenciamentoDeClinica.telasecretaria;
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


        private void cadastrarMedicos_Click(object sender, EventArgs e)
        {

            TelaCadastroMedico cadMedico = new TelaCadastroMedico();
            AddOwnedForm(cadMedico);
            cadMedico.Show();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroPaciente cadPaciente = new TelaCadastroPaciente();
            AddOwnedForm(cadPaciente);
            cadPaciente.Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaPesquisarConvenio pesqConvenio = new TelaPesquisarConvenio();
            AddOwnedForm(pesqConvenio);
            pesqConvenio.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastroConvenio cadConvenio = new TelaCadastroConvenio();
            AddOwnedForm(cadConvenio);
            cadConvenio.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarMedico pesqMedico = new TelaPesquisarMedico();
            AddOwnedForm(pesqMedico);
            pesqMedico.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarPaciente pesqPaciente = new TelaPesquisarPaciente();
            AddOwnedForm(pesqPaciente);
            pesqPaciente.Show();
        }

        private void marcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarConsulta cadConsulta = new TelaCadastrarConsulta();
            AddOwnedForm(cadConsulta);
            cadConsulta.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPesquisarConsulta pesqConsulta = new TelaPesquisarConsulta();
            AddOwnedForm(pesqConsulta);
            pesqConsulta.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastrarEspecialidade cadEspecialidade = new TelaCadastrarEspecialidade();
            AddOwnedForm(cadEspecialidade);
            cadEspecialidade.Show();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TelaPesquisarEspecialidade pesqEspecialidade = new TelaPesquisarEspecialidade();
            AddOwnedForm(pesqEspecialidade);
            pesqEspecialidade.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaCadastroSecretaria cadSecretaria = new TelaCadastroSecretaria();
            AddOwnedForm(cadSecretaria);
            cadSecretaria.Show();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TelaPesquisarSecretaria pesqSecretaria = new TelaPesquisarSecretaria();
            AddOwnedForm(pesqSecretaria);
            pesqSecretaria.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaTesteWebService telaTesteWebService = new TelaTesteWebService();
            telaTesteWebService.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TelaPesquisarConsulta teste1 = new TelaPesquisarConsulta();
            teste1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPesquisarSecretaria teste2 = new TelaPesquisarSecretaria();
            teste2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaPesquisarMedico pesqMed = new TelaPesquisarMedico();
            pesqMed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPesquisarPaciente pesqPaciente = new TelaPesquisarPaciente();
            pesqPaciente.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testarWebServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTesteWebService telaTesteWebService = new TelaTesteWebService();
            AddOwnedForm(telaTesteWebService);
            telaTesteWebService.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

