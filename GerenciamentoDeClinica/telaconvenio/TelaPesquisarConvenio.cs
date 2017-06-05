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
using GerenciamentoDeClinica.utils;

namespace GerenciamentoDeClinica.telaconvenio
{
    public partial class TelaPesquisarConvenio : Form, IConsistenciaDados
    {
        private Thread _threadSalvarDados;
        private string _savedPesquisar = "";
        private PesquisarConvenio _pesquisarConvenio;

        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";

        private readonly ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarConvenio()
        {
            InitializeComponent();
        }

        private void TelaPesquisarConvenio_Load(object sender, EventArgs e)
        {
            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _pesquisarConvenio = ClinicaXmlUtils.GetPesquisarConvenio();
            if (_pesquisarConvenio != null)
            {
                txtDescricaoFiltro.Text = _pesquisarConvenio.PesquisarDescricao;

                CarregarListView();
                //Informando a linha selecionada da ListView
                if (_pesquisarConvenio.LinhaSelecionada.HasValue)
                    listViewConvenios.Items[_pesquisarConvenio.LinhaSelecionada.Value].Selected = true;

                txtID.Text = _pesquisarConvenio.Convenio.ID_Convenio.ToString();
                txtDescricao.Text = _pesquisarConvenio.Convenio.Descricao;
            }
            else
            {
                _pesquisarConvenio = new PesquisarConvenio { Convenio = new Convenio() };
            }

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void ClearTextBoxs()
        {
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewConvenios.Items.Clear();
            try
            {
                _pesquisarConvenio.ConveniosSalvos = clinicaService.ListarConvenio(new Convenio
                {
                    Descricao = txtDescricaoFiltro.Text
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

        private void listViewConvenios_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region click in list

            if (listViewConvenios.SelectedItems.Count > 0)
            {
                _pesquisarConvenio.LinhaSelecionada = listViewConvenios.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                Convenio convenio = new Convenio()
                {
                    ID_Convenio = _pesquisarConvenio.ConveniosSalvos[_pesquisarConvenio.LinhaSelecionada.Value].ID_Convenio,
                    Descricao = _pesquisarConvenio.ConveniosSalvos[_pesquisarConvenio.LinhaSelecionada.Value].Descricao
                };

                txtID.Text = convenio.ID_Convenio.ToString();
                txtDescricao.Text = convenio.Descricao;
                txtDescricao.Enabled = true;
                btnAtualizar.Enabled = true;
                btnRemover.Enabled = true;
            }
            else
            {
                _pesquisarConvenio.LinhaSelecionada = null;
                txtID.Clear();
                txtDescricao.Clear();
                txtDescricao.Enabled = false;
                btnAtualizar.Enabled = false;
                btnRemover.Enabled = false;
            }
            #endregion
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_pesquisarConvenio.LinhaSelecionada.HasValue)
            {
                try
                {
                    var result = MessageBox.Show("Deseja remover convênio ?", "Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        clinicaService.RemoverConvenio(_pesquisarConvenio.ConveniosSalvos[_pesquisarConvenio.LinhaSelecionada.Value]);
                        listViewConvenios.Items.RemoveAt(_pesquisarConvenio.LinhaSelecionada.Value);
                        MessageBox.Show(this, "Convênio excluido com sucesso!");
                        ClearTextBoxs();
                    }
                    else
                    {
                        ClearTextBoxs();
                        txtDescricaoFiltro.Focus();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_pesquisarConvenio.LinhaSelecionada.HasValue)
            {
                try
                {
                    Convenio convenio = new Convenio()
                    {
                        ID_Convenio = Convert.ToInt32(_pesquisarConvenio.ConveniosSalvos[_pesquisarConvenio.LinhaSelecionada.Value].ID_Convenio),
                        Descricao = txtDescricao.Text
                    };

                    clinicaService.AtualizarConvenio(convenio);
                    MessageBox.Show(this, "Convênio atualizado com sucesso!");

                    _pesquisarConvenio.ConveniosSalvos[_pesquisarConvenio.LinhaSelecionada.Value] = convenio;
                    listViewConvenios.Items[_pesquisarConvenio.LinhaSelecionada.Value].SubItems[1].Text = convenio.Descricao;

                    ClearTextBoxs();

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
            foreach (Convenio convenio in _pesquisarConvenio.ConveniosSalvos)
            {
                ListViewItem linha = listViewConvenios.Items.Add(convenio.ID_Convenio.ToString());
                linha.SubItems.Add(convenio.Descricao);
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
                _pesquisarConvenio.PesquisarDescricao = txtDescricaoFiltro.Text;
                _pesquisarConvenio.Convenio.Descricao = txtDescricao.Text;

                int result;
                if (Int32.TryParse(txtID.Text, out result))
                    _pesquisarConvenio.Convenio.ID_Convenio = result;

                if (!_savedPesquisar.Equals(ClinicaXmlUtils.ToXml(_pesquisarConvenio)))
                {
                    //altera o cliente para um novo
                    _savedPesquisar = ClinicaXmlUtils.ToXml(_pesquisarConvenio);

                    ClinicaXmlUtils.SetPesquisarConvenio(_pesquisarConvenio);
                }
            }
        }

        private void TelaPesquisarConvenio_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "pesquisar_convenio")]
    public sealed class PesquisarConvenio
    {
        [XmlElement(ElementName = "pesquisar_descricao")]
        public string PesquisarDescricao { get; set; }
        [XmlElement(ElementName = "linha_selecionada")]
        public int? LinhaSelecionada { get; set; }
        [XmlElement(ElementName = "convenios_salvos")]
        public List<Convenio> ConveniosSalvos { get; set; }
        public Convenio Convenio { get; set; }
    }
}

