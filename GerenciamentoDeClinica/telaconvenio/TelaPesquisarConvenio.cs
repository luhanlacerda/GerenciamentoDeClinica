using GerenciamentoDeClinica.localhost;
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
    public partial class TelaPesquisarConvenio : Form
    {

        ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarConvenio()
        {
            InitializeComponent();
        }

        #region Enabled Buttons and Clear filds
        void enabledPesquisar()
        {
            btnPesquisar.Enabled = false;
            txtDescricaoFiltro.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
        }

        void enabledBusca()
        {
            btnPesquisar.Enabled = true;
            txtDescricaoFiltro.Enabled = true;
            btnBusca.Enabled = false;
            txtDescricao.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnAtualizar.Enabled = false;
            txtDescricaoFiltro.Focus();
            ClearTextBoxs();
        }

        void enabledEditar()
        {
            btnPesquisar.Enabled = false;
            txtDescricaoFiltro.Enabled = false;
            btnBusca.Enabled = true;
            txtDescricao.Enabled = true;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;
        }

        void enabledRemover()
        {
            btnRemover.Enabled = false;
            txtDescricao.Enabled = false;
            btnAtualizar.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
        }

        void enabledAtualizar()
        {
            btnRemover.Enabled = false;
            txtDescricao.Enabled = false;
            btnAtualizar.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
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
        #endregion

        void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewConvenios.SelectedItems.Clear();
            try
            {

                Convenio[] convenios = clinicaService.ListarConvenio(new Convenio
                {
                    Descricao = txtDescricaoFiltro.Text
                });


                foreach (Convenio convenio in convenios)
                {
                    ListViewItem linha = listViewConvenios.Items.Add(convenio.ID_Convenio.ToString());
                    linha.SubItems.Add(convenio.Descricao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            enabledPesquisar();
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
                    ID_Convenio = Convert.ToInt32(selected.Text)
                };

                try
                {
                    //fachada.Remover(convenio);
                    listViewConvenios.Items.Remove(selected);
                    MessageBox.Show("Convenio excluido com sucesso!");
                    ClearTextBoxs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            enabledRemover();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                
                MessageBox.Show("Convenio atualizado com sucesso!");
                txtID.Clear();
                txtDescricao.Clear();
                txtDescricao.Enabled = false;

                listViewConvenios.Items.Clear();
                
                /*
                foreach (Convenio listarEspecialidades in convenios)
                {
                    ListViewItem linha = listViewConvenios.Items.Add(listarEspecialidades.ID_Convenio.ToString());
                    linha.SubItems.Add(listarEspecialidades.Descricao.ToString());
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            enabledAtualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enabledEditar();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            listViewConvenios.Items.Clear();
            enabledBusca();
        }
    }
}

