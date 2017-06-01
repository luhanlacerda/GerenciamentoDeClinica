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

namespace GerenciamentoDeClinica.telaespecialidade
{
    public partial class TelaPesquisarEspecialidade : Form
    {
        ClinicaService clinicaService = new ClinicaService();

        public TelaPesquisarEspecialidade()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listViewEspecialidades.Items.Clear();
            try
            {
                Especialidade[] especialidades = clinicaService.ListarEspecialidade(new Especialidade
                {
                    ID_Especialidade = 0,
                    Descricao = txtPesqDesc.Text
                });

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
                    ID_Especialidade = Convert.ToInt32(selected.Text),
                    ID_EspecialidadeSpecified = true
                };

                try
                {
                    clinicaService.RemoverEspecialidade(especialidade);
                    listViewEspecialidades.Items.Remove(selected);
                    MessageBox.Show("Especialidade excluída com sucesso!");
                    txtDescricao.Enabled = false;
                    txtID.Clear();
                    txtDescricao.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listViewEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEspecialidades.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewEspecialidades.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Especialidade especialidade = new Especialidade()
                {
                    ID_Especialidade = Convert.ToInt32(selected.Text),
                    Descricao = selected.SubItems[1].Text
                };

                txtID.Text = Convert.ToString(especialidade.ID_Especialidade);
                txtDescricao.Text = especialidade.Descricao;

                txtDescricao.Enabled = true;
                btnAtualizar.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Especialidade especialidade = new Especialidade()
            {
                ID_Especialidade = Convert.ToInt32(txtID.Text),
                ID_EspecialidadeSpecified = true,
                Descricao = txtDescricao.Text
            };

            try
            {
                clinicaService.AtualizarEspecialidade(especialidade);
                MessageBox.Show("Especialidade atualizada com sucesso!");
                txtID.Clear();
                txtDescricao.Clear();
                txtDescricao.Enabled = false;

                listViewEspecialidades.Items.Clear();
                Especialidade[] especialidades = clinicaService.ListarEspecialidade(new Especialidade
                {
                    ID_Especialidade = 0
                });

                foreach (Especialidade listaEspecialidades in especialidades)
                {
                    ListViewItem linha = listViewEspecialidades.Items.Add(listaEspecialidades.ID_Especialidade.ToString());
                    linha.SubItems.Add(listaEspecialidades.Descricao.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}

