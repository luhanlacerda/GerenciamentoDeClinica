using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Atendimento.localhost;
using Atendimento.utils;

namespace Atendimento
{
    public partial class TelaPrincipal : Form
    {
        public const string IP = "192.168.1.3";
        public const int PORT = 6969;

        public Thread thread;
        private TcpListener tcpListener;

        private const string ERROR_WEBSERVICE = @"Erro de conexão o servidor.";
        private int? selectedRow;
        private List<Atendimento> list = new List<Atendimento>();


        private readonly ClinicaService service = new ClinicaService();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaAtendimento_Load(object sender, EventArgs e)
        {
            comboEstado.DataSource = new BindingList<Estado>(service.ListarEstado(new Estado()));
            comboEstado.DisplayMember = "Descricao";

            thread = new Thread(Run);
            thread.Start();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (selectedRow.HasValue)
            {
                try
                {
                    service.RemoverConsulta(list[selectedRow.Value].Consulta);
                    MessageBox.Show(@"Consulta removida com sucesso!");
                    //list[selectedRow.Value].writer.Write("Consulta " + list[selectedRow.Value].Consulta.ID_Consulta + " removida com sucesso.");
                    CloseSelectedConnection(list[selectedRow.Value]);
                    list.RemoveAt(selectedRow.Value);
                    Invoke(new MethodInvoker(delegate ()
                    {
                        listView1.Items.RemoveAt(selectedRow.Value);
                    }));
                    ClearTextBoxs();
                }
                catch (WebException)
                {
                    MessageBox.Show(ERROR_WEBSERVICE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextBoxs()
        {
            groupBox2.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            comboEstado.SelectedIndex = 0;

        }

        public void Run()
        {
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
                tcpListener = new TcpListener(ipEndPoint);
                tcpListener.Start();

                while (true)
                {
                    Atendimento atendimento = new Atendimento();
                    atendimento.socket = tcpListener.AcceptSocket();
                    atendimento.stream = new NetworkStream(atendimento.socket);
                    atendimento.writer = new BinaryWriter(atendimento.stream);
                    atendimento.reader = new BinaryReader(atendimento.stream);
                    atendimento.Consulta = ClinicaXmlUtils.FromXml<Consulta>(atendimento.reader.ReadString());
                    if (list.Any(n => n.Consulta.ID_Consulta == atendimento.Consulta.ID_Consulta))
                    {
                        atendimento.writer.Write("Consulta já, existente.");
                    }
                    else
                    {
                        list.Add(atendimento);
                        Invoke(new MethodInvoker(delegate()
                        {
                            ListViewItem linha = listView1.Items.Add(atendimento.Consulta.ID_Consulta.ToString());
                            linha.SubItems.Add(atendimento.Consulta.Medico.Nome);
                            linha.SubItems.Add(atendimento.Consulta.Paciente.Nome);
                        }));
                    }
                    atendimento.writer.Write("FIM");
                }
            }
            catch (SocketException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void CarregarEditar(Consulta consulta)
        {
            comboEstado.SelectedIndex = consulta.Estado.ID_Estado - 1;
            txtObservacoes.Text = consulta.Observacoes;
            txtReceita.Text = consulta.Receita;
        }

        private void CloseSelectedConnection(Atendimento atendimento)
        {
            atendimento.reader?.Close();
            atendimento.writer?.Close();
            atendimento.stream?.Close();
            atendimento.socket?.Close();
        }

        private void CloseConnection()
        {
            tcpListener?.Stop();
        }

        private void TelaAtendimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnection();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedRow = listView1.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0).Index;

                CarregarEditar(list[selectedRow.Value].Consulta);
                btnRemover.Enabled = true;
            }
            else
            {
                selectedRow = null;
                ClearTextBoxs();
                btnRemover.Enabled = false;
            }
        }
    }

    public sealed class Atendimento
    {
        public Socket socket { get; set; }
        public NetworkStream stream { get; set; }
        public BinaryWriter writer { get; set; }
        public BinaryReader reader { get; set; }
        public Consulta Consulta { get; set; }
    }
}
