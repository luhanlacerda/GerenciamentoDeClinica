﻿using Biblioteca.classesBasicas;
using Biblioteca.convenio;
using Biblioteca.medico;
using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.paciente
{
    public partial class TelaCadastroPaciente : Form
    {
        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        private void TelaCadastroPaciente_Load(object sender, EventArgs e)
        {
            comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.ID_Paciente = Convert.ToInt32(textBox1.Text);
                paciente.Convenio = new Convenio { ID_Convenio = 1 };

                paciente.Nome = txtNome.Text;
                paciente.CPF = maskedCPF.Text;
                paciente.RG = txtRG.Text;
                paciente.Contato = maskedCell.Text;
                paciente.Dt_Nascimento = dateTimeDtNasc.Value;
                paciente.Email = txtEmail.Text;
                paciente.Endereco.CEP = maskedCEP.Text;
                paciente.Endereco.Logradouro = txtLogradouro.Text;
                paciente.Endereco.Complemento = txtComplemento.Text;
                paciente.Endereco.Numero = txtNumero.Text;
                paciente.Endereco.Bairro = txtBairro.Text;
                paciente.Endereco.Cidade = txtCidade.Text;
                paciente.Endereco.UF = comboUF.SelectedItem.ToString();
                paciente.Endereco.Pais = txtPais.Text;
                RadioButton radio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radio.Name == rbSolteiro.Name)
                {
                    paciente.Estado_Civil = rbSolteiro.Text;
                }
                else if (radio.Name == rbCasado.Name)
                {
                    paciente.Estado_Civil = rbCasado.Text;
                }
                else
                {
                    paciente.Estado_Civil = rbViuvo.Text;
                }

                new NegocioPaciente().Cadastrar(paciente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            
        }

        private void clearAll(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            if (maskedCEP.MaskFull)
            {
                Endereco endereco = CepUtils.PegarEndereco(maskedCEP.Text);
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtComplemento.Text = endereco.Complemento;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    comboUF.SelectedItem = endereco.UF;

                }
            }
        }
    }
}