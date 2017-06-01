using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telaconvenio
{
    public partial class TelaPesquisarConvenio : Form
    {
        private const string ERROR_WEBSERVICE = "Erro de conexão o servidor.";

        ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarConvenio()
        {
            InitializeComponent();
        }

        #region Clear filds

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
        #endregion

        void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewConvenios.Items.Clear();
            try
            {
                Convenio[] convenios = clinicaService.ListarConvenio(new Convenio
                {
                    ID_Convenio = 0,
                    Descricao = txtDescricaoFiltro.Text
                });

                foreach (Convenio convenio in convenios)
                {
                    ListViewItem linha = listViewConvenios.Items.Add(convenio.ID_Convenio.ToString());
                    linha.SubItems.Add(convenio.Descricao);
                }

            }
            catch (WebException)
            {
                MessageBox.Show(ERROR_WEBSERVICE);
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

        }

        private void listViewConvenios_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region click in list
            if (listViewConvenios.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewConvenios.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Convenio convenio = new Convenio()
                {
                    ID_Convenio = Convert.ToInt32(selected.Text),
                    Descricao = selected.SubItems[1].Text
                };

                txtID.Text = Convert.ToString(convenio.ID_Convenio);
                txtDescricao.Text = convenio.Descricao;
                txtDescricao.Enabled = true;
                btnAtualizar.Enabled = true;
                btnRemover.Enabled = true;
            }
            #endregion
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listViewConvenios.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewConvenios.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Convenio convenio = new Convenio()
                {
                    ID_Convenio = Convert.ToInt32(selected.Text),
                    ID_ConvenioSpecified = true

                };

                try
                {
                    clinicaService.RemoverConvenio(convenio);
                    listViewConvenios.Items.Remove(selected);
                    MessageBox.Show("Convênio excluido com sucesso!");
                    ClearTextBoxs();
                }
                //Caso haja um erro no WebService irá mostrar uma mensagem de erro
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {            
            if (listViewConvenios.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewConvenios.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Convenio convenio = new Convenio()
                {
                    ID_Convenio = Convert.ToInt32(selected.Text),
                    ID_ConvenioSpecified = true,
                    Descricao = txtDescricao.Text
                };

                try
                {
                    clinicaService.AtualizarConvenio(convenio);
                    MessageBox.Show("Convênio atualizado com sucesso!");

                    selected.SubItems[1].Text = txtDescricao.Text;

                    ClearTextBoxs();
                        
                }
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }

            }
        }

    }
}

