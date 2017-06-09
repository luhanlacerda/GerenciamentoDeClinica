using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClinica.telaatendimento
{
    public partial class TelaAtendimento : Form
    {
        private const string IP = "172.";
        private const int PORT = 6969;

        private TcpClient tcpClient;
        private NetworkStream stream;
        private BinaryWriter writer;

        public TelaAtendimento()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                //conectando ao servidor
                tcpClient.Connect(IP, PORT);

                stream = tcpClient.GetStream();
                writer = new BinaryWriter(stream);
                writer.Write(Convert.ToInt32(numBaia.Value));
                MessageBox.Show(@"Baia livre informada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer?.Close();
                stream?.Close();
                tcpClient?.Close();
            }
        }
    }
}
