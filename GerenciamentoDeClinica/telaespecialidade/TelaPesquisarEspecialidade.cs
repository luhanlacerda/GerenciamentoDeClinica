using Biblioteca.especialidade;
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

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaPesquisarEspecialidade : Form
    {
        Fachada fachada = new Fachada();

        public TelaPesquisarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewEspecialidades.Items.Clear();
            try
            {
                List<Especialidade> especialidades = fachada.Listar(new Especialidade());

                foreach (Especialidade especialidade in especialidades)
                {
                    ListViewItem linha = listViewEspecialidades.Items.Add(especialidade.ID_Especialidade.ToString());
                    linha.SubItems.Add(especialidade.Descricao.ToString());
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listViewEspecialidades.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewEspecialidades.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Especialidade especialidade = new Especialidade()
                {
                    ID_Especialidade = Convert.ToInt32(selected.Text)
                };

                try
                {
                    fachada.Remover(especialidade);
                    listViewEspecialidades.Items.Remove(selected);
                    MessageBox.Show("Especialidade excluída com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listViewEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            btnRemover.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listViewEspecialidades.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewEspecialidades.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Especialidade especialidade = new Especialidade()
                {
                    ID_Especialidade = Convert.ToInt32(selected.Text),
                    Descricao = selected.Text
                };

                
            }
        }
    }
}
