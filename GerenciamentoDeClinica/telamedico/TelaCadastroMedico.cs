using GerenciamentoDeClinica.localhost;
using GerenciamentoDeClinica.utils;
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
using System.Xml.Serialization;

namespace GerenciamentoDeClinica.telamedico
{
    public partial class TelaCadastroMedico : Form, IConsistenciaDados
    {
        private Thread _threadSalvarDados;
        private string _savedCadastrar = "";
        private CadastrarMedico _cadastrarMedico;

        public TelaCadastroMedico()
        {
            InitializeComponent();
        }

        private void TelaCadastroMedico_Load(object sender, EventArgs e)
        {
            //comboUF.Items.AddRange(ClinicaUtils.UF_LIST);
            comboUF.DataSource = ClinicaUtils.UF_LIST;

            ClinicaService service = new ClinicaService();
            comboBox1.DataSource = new BindingList<Especialidade>(service.ListarEspecialidade(new Especialidade()));
            comboBox1.DisplayMember = "Descricao";

            //Carregamento dos dados
            ClinicaXmlUtils.Create();
            _cadastrarMedico = ClinicaXmlUtils.GetCadastrarMedico();
            if (_cadastrarMedico != null)
                CarregarEditar(_cadastrarMedico.Medico);
            else
                _cadastrarMedico = new CadastrarMedico { Medico = new Medico() };

            _threadSalvarDados = new Thread(SalvarDados);
            _threadSalvarDados.Start();
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            if (maskedCEP.MaskFull)
            {
                Endereco endereco = ClinicaUtils.PegarEndereco(maskedCEP.Text);
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                _cadastrarMedico.Medico = GetMedico();

                ClinicaService service = new ClinicaService();
                service.CadastrarMedico(_cadastrarMedico.Medico);
                MessageBox.Show(@"Médico atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
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
            _cadastrarMedico.Medico = GetMedico();

            if (!_savedCadastrar.Equals(ClinicaXmlUtils.ToXml(_cadastrarMedico)))
            {
                //altera o cliente para um novo
                _savedCadastrar = ClinicaXmlUtils.ToXml(_cadastrarMedico);

                ClinicaXmlUtils.SetCadastrarMedico(_cadastrarMedico);
            }
        }

        private void CarregarEditar(Medico medico)
        {
            txtNome.Text = medico.Nome;
            maskedCPF.Text = medico.CPF;
            txtRG.Text = medico.RG;
            maskedCell.Text = medico.Contato;
            txtCRM.Text = medico.CRM;
            comboBox1.SelectedIndex = medico.Especialidade.ID_Especialidade - 1;
            dateTimeDtNasc.Value = medico.Dt_Nascimento;
            txtEmail.Text = medico.Email;
            RadioButton radioButton = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Text == medico.Estado_Civil);
            if (radioButton != null)
                radioButton.Checked = true;
            maskedCEP.Text = medico.Endereco.CEP;
            txtLogradouro.Text = medico.Endereco.Logradouro;
            txtNumero.Text = medico.Endereco.Numero;
            txtComplemento.Text = medico.Endereco.Complemento;
            txtBairro.Text = medico.Endereco.Bairro;
            txtCidade.Text = medico.Endereco.Cidade;
            comboUF.SelectedItem = medico.Endereco.UF;
            txtPais.Text = medico.Endereco.Pais;
        }

        //Adquirir valor do combobox Especialidade da thread principal
        private Especialidade GetEspecialidade()
        {
            Especialidade especialidade = null;

            Invoke(new MethodInvoker(delegate ()
            {
                if (!comboBox1.IsDisposed)
                    especialidade = ((BindingList<Especialidade>)comboBox1.DataSource)
                        .ElementAt(comboBox1.SelectedIndex);
            }));
            return especialidade;
        }

        private string GetEstadoCivil()
        {
            //Caso não seja nulo retornará o Text do RadioButton selecionado ou nulo (? = informa)
            return groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)?.Text;
        }

        //Adquirir valor do combobox UF da thread principal
        private string GetUF()
        {
            string text = null;

            Invoke(new MethodInvoker(delegate () { if (!comboUF.IsDisposed) text = comboUF.SelectedItem.ToString(); }));
            return text;
        }

        private Medico GetMedico()
        {
            return new Medico
            {
                CRM = txtCRM.Text,
                Especialidade = GetEspecialidade(),
                Nome = txtNome.Text,
                RG = txtRG.Text,
                CPF = maskedCPF.Text,
                Endereco = new Endereco
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    UF = GetUF(),
                    CEP = maskedCEP.Text,
                    Pais = txtPais.Text
                },
                Contato = maskedCell.Text,
                Dt_Nascimento = dateTimeDtNasc.Value,
                Email = lblEmail.Text,
                Estado_Civil = GetEstadoCivil()
            };
        }

        private void TelaCadastroMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dados poderiam ser perdidos, caso o Form fosse fechado.
            SaveXml();
        }
    }

    [XmlRoot(ElementName = "cadastrar_medico")]
    public sealed class CadastrarMedico
    {
        public Medico Medico { get; set; }
    }
}
