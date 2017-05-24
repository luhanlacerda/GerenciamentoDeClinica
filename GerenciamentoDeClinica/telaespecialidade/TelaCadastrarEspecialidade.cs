using Biblioteca.especialidade;
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

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaCadastrarEspecialidade : Form
    {
        private string xmlLocation = @"data.xml";
        private Especialidade especialidade;
        private Thread threadSalvarDados;
        private static XmlDocument document;

        public TelaCadastrarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidade especialidade = new Especialidade();

                especialidade.ID_Especialidade = Convert.ToInt32(txtID.Text);
                especialidade.Descricao = txtDescricao.Text;

                new EspecialidadeBD().Cadastrar(especialidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }


        }

        private void TelaCadastrarEspecialidade_Load(object sender, EventArgs e)
        {
            //Ao carregar o Form, criar um cliente, documento XML, thread para salvar dados
            especialidade = new Especialidade();
            document = new XmlDocument();
            threadSalvarDados = new Thread(new ThreadStart(SalvarDados));

            //Verificar se existem dados a serem carregados
            if (File.Exists(xmlLocation))
            {
                document.Load(xmlLocation);

                txtDescricao.Text = document.SelectSingleNode("/Especialidade/Nome").InnerText;
                //txtID.Text = document.SelectSingleNode("/Especialidade/Id").InnerText;
            }

            //Após carregar todos os dados, inicia a thread de salvar dados
            threadSalvarDados.Start();

        }

        private void SalvarDados()
        {
            return;

            //Executa enquanto o Form for executado
            while (Visible)
            {
                SaveXML();

                //Salvar a cada 1.5s
                Thread.Sleep(1500);
            }

            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXML();
        }

        private void SaveXML()
        {
            Especialidade newEspecialidade = new Especialidade
            {
                Descricao = txtDescricao.Text
            };

            //Verificar se há alguma mudança
            if (especialidade.Equals(newEspecialidade))
            {
                //altera o cliente para um novo
                especialidade = newEspecialidade;

                document.LoadXml(especialidade.ToXML());
                document.Save(xmlLocation);
            }
        }
    }
}
