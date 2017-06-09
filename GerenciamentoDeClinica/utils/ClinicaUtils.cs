using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net.Sockets;
using System.ServiceModel;
using GerenciamentoDeClinica.localhost;

namespace GerenciamentoDeClinica.utils
{
    public class ClinicaUtils
    {
        public const string IP = "192.168.1.3";
        public const int PORT = 6969;

        public static TcpClient tcpClient;
        public static NetworkStream stream;
        public static BinaryWriter writer;
        public static BinaryReader Reader;

        public static readonly string[] UF_LIST = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
        private const string CEP_URL = "https://viacep.com.br/ws/{0}/xml/";

        public static Endereco PegarEndereco(string cep)
        {
            //Endereço null = endereço não encontrado
            Endereco endereco;

            //Tentará pegar o endereço pelo CEP
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(string.Format(CEP_URL, cep.Replace("-", "")));

                endereco = new Endereco();
                //Pegará o texto contido em um node single
                endereco.CEP = xml.DocumentElement.SelectSingleNode("/xmlcep/cep").InnerText;
                endereco.Logradouro = xml.DocumentElement.SelectSingleNode("/xmlcep/logradouro").InnerText;
                endereco.Complemento = xml.DocumentElement.SelectSingleNode("/xmlcep/complemento").InnerText;
                endereco.Bairro = xml.DocumentElement.SelectSingleNode("/xmlcep/bairro").InnerText;
                endereco.Cidade = xml.DocumentElement.SelectSingleNode("/xmlcep/localidade").InnerText;
                endereco.UF = xml.DocumentElement.SelectSingleNode("/xmlcep/uf").InnerText;
            }
            catch (Exception)
            {
                return null;
            }

            return endereco;
        }
    }
}
