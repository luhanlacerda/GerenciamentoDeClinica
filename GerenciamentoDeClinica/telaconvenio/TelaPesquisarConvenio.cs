using Biblioteca.convenio;
using Biblioteca.fachada;
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
        Fachada fachada = new Fachada();

        public TelaPesquisarConvenio()
        {
            InitializeComponent();
        }

        public void enabledPesquisar()
        {
            btnPesquisar.Enabled = false;
            txtIDFiltro.Enabled = false;
            txtDescricaoFiltro.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
        }

        public void enabledBusca()
        {
            btnPesquisar.Enabled = true;
            txtIDFiltro.Enabled = true;
            txtDescricaoFiltro.Enabled = true;
            btnBusca.Enabled = false;
            txtDescricao.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
            btnAtualizar.Enabled = false;
            txtIDFiltro.Focus();
            ClearTextBoxes();
        }

        public void enabledEditar()
        {
            btnPesquisar.Enabled = false;
            txtIDFiltro.Enabled = false;
            txtDescricaoFiltro.Enabled = false;
            btnBusca.Enabled = true;
            txtDescricao.Enabled = true;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;
        }

        public void enabledRemover()
        {
            btnRemover.Enabled = false;
            txtDescricao.Enabled = false;
            btnAtualizar.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
        }

        public void enabledAtualizar()
        {
            btnRemover.Enabled = false;
            txtDescricao.Enabled = false;
            btnAtualizar.Enabled = false;
            btnBusca.Enabled = true;
            btnEditar.Enabled = true;
        }

        public void ClearTextBoxes()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewConvenios.SelectedItems.Clear();
            try
            {
                enabledPesquisar();

                List<Convenio> convenios = fachada.Listar(new Convenio());

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

            //listViewConvenios.Items.Clear();
        }

        private void listViewConvenios_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    fachada.Remover(convenio);
                    listViewConvenios.Items.Remove(selected);
                    MessageBox.Show("Convenio excluido com sucesso!");
                    ClearTextBoxes();  
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
            
           Convenio convenio = new Convenio()
            {
                ID_Convenio = Convert.ToInt32(txtID.Text),
                Descricao = txtDescricao.Text
            };

            try
            {
                fachada.Atualizar(convenio);
                MessageBox.Show("Convenio atualizado com sucesso!");
                txtID.Clear();
                txtDescricao.Clear();
                txtDescricao.Enabled = false;

                listViewConvenios.Items.Clear();

                List<Convenio> convenios = fachada.Listar(new Convenio());

                foreach (Convenio listarEspecialidades in convenios)
                {
                    ListViewItem linha = listViewConvenios.Items.Add(listarEspecialidades.ID_Convenio.ToString());
                    linha.SubItems.Add(listarEspecialidades.Descricao.ToString());
                }
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

