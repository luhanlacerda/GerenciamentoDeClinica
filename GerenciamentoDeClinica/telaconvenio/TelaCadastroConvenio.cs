using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using GerenciamentoDeClinica.utils;

namespace GerenciamentoDeClinica.telaconvenio
{
    public partial class TelaCadastroConvenio : Form, IConsistenciaDados
    {
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private CadastrarConvenio _cadastrarConvenio;

        public TelaCadastroConvenio()
        {
            InitializeComponent();
        }

        private void TelaCadastroConvenio_Load(object sender, EventArgs e)
        {
            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarConvenio = ClinicaXmlUtils.GetCadastrarConvenio();
            if (_cadastrarConvenio != null)
                txtDescricao.Text = _cadastrarConvenio.Convenio.Descricao;
            else
                _cadastrarConvenio = new CadastrarConvenio { Convenio = new Convenio() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void ClearTextBoxs()
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
                _cadastrarConvenio.Convenio.Descricao = txtDescricao.Text;

                new ClinicaService().CadastrarConvenio(_cadastrarConvenio.Convenio);
                MessageBox.Show("Convenio cadastrado com sucesso.");
                ClearTextBoxs();
                txtDescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        public void SalvarDados()
        {
            //Executa enquanto o Form for executado
            while (Visible)
            {
                SaveXml();

                //Salvar a cada 1.5s
                Thread.Sleep(1500);
            }
        }

        public void SaveXml()
        {
            _cadastrarConvenio.Convenio.Descricao = txtDescricao.Text;

            if (_savedCadastrar == ClinicaXmlUtils.ToXml(_cadastrarConvenio)) return;
            //altera o cliente para um novo
            _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarConvenio);

            ClinicaXmlUtils.SetCadastrarConvenio(_cadastrarConvenio);
        }

        private void TelaCadastroConvenio_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "cadastrar_convenio")]
    public sealed class CadastrarConvenio
    {
        public Convenio Convenio { get; set; }
    }
}
