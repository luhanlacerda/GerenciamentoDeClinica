﻿using Biblioteca.convenio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.convenio
{
    public partial class TelaCadastroConvenio : Form
    {
        public TelaCadastroConvenio()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio();

            convenio.ID_Convenio = Convert.ToInt32(txtID.Text);
            convenio.Descricao = txtDescricao.Text;


            new ConvenioBD().Cadastrar(convenio);
        }

        
    }
}
