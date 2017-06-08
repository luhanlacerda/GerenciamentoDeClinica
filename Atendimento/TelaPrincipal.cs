using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class TelaPrincipal : Form
    {
        private const string IP = "192.168.1.3";
        private const int PORT = 6969;
        private bool open;

        private Thread thread;
        private TcpListener tcpListener;
        private Socket socket;
        private NetworkStream stream;
        private BinaryReader reader;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(Run);
            thread.Start();
        }

        public void Run()
        {
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
                tcpListener = new TcpListener(ipEndPoint);
                tcpListener.Start();
                open = true;

                while (true)
                {
                    socket = tcpListener.AcceptSocket();
                    stream = new NetworkStream(socket);
                    reader = new BinaryReader(stream);

                    int baia = reader.ReadInt32();
                    Invoke(new MethodInvoker(
                        delegate { lblNumero.Text = baia.ToString(); }
                    ));
                }
            }
            catch (SocketException){}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }

        private void CloseConnection()
        {
            reader?.Close();
            stream?.Close();
            socket?.Close();
            tcpListener?.Stop();
        }
    }
}
