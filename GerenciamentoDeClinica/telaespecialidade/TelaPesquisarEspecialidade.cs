using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using GerenciamentoDeClinica.telaconvenio;
using GerenciamentoDeClinica.utils;

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaPesquisarEspecialidade : Form
    {
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarEspecialidade _pesquisarEspecialidade;
        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";
        private readonly ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarEspecialidade()
        {
            InitializeComponent();
        }

        private void TelaPesquisarEspecialidade_Load(object sender, EventArgs e)
        {
            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarEspecialidade = ClinicaXmlUtils.GetPesquisarEspecialidade();
            if (_pesquisarEspecialidade != null)
            {
                txtPesqDesc.Text = _pesquisarEspecialidade.PesquisarDescricao;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarEspecialidade.LinhaSelecionada.HasValue)
                    listViewEspecialidades.Items[_pesquisarEspecialidade.LinhaSelecionada.Value].Selected = true;

                txtID.Text = _pesquisarEspecialidade.Especialidade.ID_Especialidade.ToString();
                txtDescricao.Text = _pesquisarEspecialidade.Especialidade.Descricao;
            }
            else
            {
                _pesquisarEspecialidade = new PesquisarEspecialidade { Especialidade = new Especialidade() };
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewEspecialidades.Items.Clear();
            try
            {
                _pesquisarEspecialidade.EspecialidadesSalvas = clinicaService.ListarEspecialidade(new Especialidade
                {
                    Descricao = txtPesqDesc.Text
                }).ToList();

                CarregarListView();
            }
            catch (WebException)
            {
                MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxs()
        {
            groupBox3.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_pesquisarEspecialidade.LinhaSelecionada.HasValue)
            {
                try
                {
                    var result = MessageBox.Show(@"Deseja remover a especialidade?", @"Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        clinicaService.RemoverEspecialidade(_pesquisarEspecialidade.EspecialidadesSalvas[_pesquisarEspecialidade.LinhaSelecionada.Value]);
                        listViewEspecialidades.Items.RemoveAt(_pesquisarEspecialidade.LinhaSelecionada.Value);
                        MessageBox.Show(this, @"Especialidade excluida com sucesso!");
                        ClearTextBoxs();
                        txtPesqDesc.Focus();
                    }
                    else
                    {
                        ClearTextBoxs();
                        txtPesqDesc.Focus();
                    }
                }
                //Caso haja um erro no WebService irá mostrar uma mensagem de erro
                catch (WebException)
                {
                    MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listViewEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEspecialidades.SelectedItems.Count > 0)
            {
                _pesquisarEspecialidade.LinhaSelecionada = listViewEspecialidades.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                Especialidade especialidade = new Especialidade()
                {
                    ID_Especialidade = _pesquisarEspecialidade.EspecialidadesSalvas[_pesquisarEspecialidade.LinhaSelecionada.Value].ID_Especialidade,
                    Descricao = _pesquisarEspecialidade.EspecialidadesSalvas[_pesquisarEspecialidade.LinhaSelecionada.Value].Descricao
                };

                txtID.Text = especialidade.ID_Especialidade.ToString();
                txtDescricao.Text = especialidade.Descricao;
                txtDescricao.Enabled = true;
                btnAtualizar.Enabled = true;
                btnRemover.Enabled = true;
            }
            else
            {
                _pesquisarEspecialidade.LinhaSelecionada = null;
                txtID.Clear();
                txtDescricao.Clear();
                txtDescricao.Enabled = false;
                btnAtualizar.Enabled = false;
                btnRemover.Enabled = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarEspecialidade.LinhaSelecionada.HasValue)
            {
                try
                {
                    Especialidade especialidade = new Especialidade()
                    {
                        ID_Especialidade = Convert.ToInt32(_pesquisarEspecialidade.EspecialidadesSalvas[_pesquisarEspecialidade.LinhaSelecionada.Value].ID_Especialidade),
                        Descricao = txtDescricao.Text
                    };

                    clinicaService.AtualizarEspecialidade(especialidade);
                    MessageBox.Show(this, @"Especialidade atualizada com sucesso!");

                    _pesquisarEspecialidade.EspecialidadesSalvas[_pesquisarEspecialidade.LinhaSelecionada.Value] = especialidade;
                    listViewEspecialidades.Items[_pesquisarEspecialidade.LinhaSelecionada.Value].SubItems[1].Text = especialidade.Descricao;

                    ClearTextBoxs();
                    txtPesqDesc.Focus();

                }
                catch (WebException)
                {
                    MessageBox.Show(this, ERROR_WEBSERVICE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CarregarListView()
        {
            listViewEspecialidades.Items.Clear();
            foreach (Especialidade especialidade in _pesquisarEspecialidade.EspecialidadesSalvas)
            {
                ListViewItem linha = listViewEspecialidades.Items.Add(especialidade.ID_Especialidade.ToString());
                linha.SubItems.Add(especialidade.Descricao);
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
            if (!IsDisposed)
            {
                _pesquisarEspecialidade.PesquisarDescricao = txtPesqDesc.Text;
                _pesquisarEspecialidade.Especialidade.Descricao = txtDescricao.Text;

                int result;
                if (Int32.TryParse(txtID.Text, out result))
                    _pesquisarEspecialidade.Especialidade.ID_Especialidade = result;

                if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarEspecialidade)))
                {
                    //altera o cliente para um novo
                    _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarEspecialidade);

                    ClinicaXmlUtils.SetPesquisarEspecialidade(_pesquisarEspecialidade);
                }
            }
        }

        private void TelaPesquisarEspecialidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "pesquisar_especialidade")]
    public sealed class PesquisarEspecialidade
    {
        [XmlElement(ElementName = "pesquisar_descricao")]
        public string PesquisarDescricao { get; set; }
        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "especialidades_salvas")]
        public List<Especialidade> EspecialidadesSalvas { get; set; }
        public Especialidade Especialidade { get; set; }
    }

}