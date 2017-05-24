﻿using Biblioteca.especialidade;
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


        }
    }
}

