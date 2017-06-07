using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaCadastrarEspecialidade : Form
    {
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private CadastrarEspecialidade _cadastrarEspecialidade;

        public TelaCadastrarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show(this, @"Informar descrição da especialidade");
                }
                Especialidade especialidade = new Especialidade()
                {
                    Descricao = txtDescricao.Text
                };
                new ClinicaService().CadastrarEspecialidade(especialidade);

                MessageBox.Show("Especialidade cadastrada com sucesso!");
                txtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }


        }

        private void TelaCadastrarEspecialidade_Load(object sender, EventArgs e)
        {
            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarEspecialidade = ClinicaXmlUtils.GetCadastrarEspecialidade();
            if (_cadastrarEspecialidade != null)
                txtDescricao.Text = _cadastrarEspecialidade.Especialidade.Descricao;
            else
                _cadastrarEspecialidade = new CadastrarEspecialidade { Especialidade = new Especialidade() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        public void SaveXml()
        {
            _cadastrarEspecialidade.Especialidade.Descricao = txtDescricao.Text;

            if (_savedCadastrar == ClinicaXmlUtils.ToXml(_cadastrarEspecialidade)) return;
            //altera a especialidade para uma nova
            _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarEspecialidade);

            ClinicaXmlUtils.SetCadastrarEspecialidade(_cadastrarEspecialidade);
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

        private void TelaCadastrarEspecialidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "cadastrar_especialidade")]
    public sealed class CadastrarEspecialidade
    {
        public Especialidade Especialidade { get; set; }
    }
}

