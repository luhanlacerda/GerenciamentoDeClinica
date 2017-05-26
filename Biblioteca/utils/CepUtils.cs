using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Biblioteca.classesBasicas;
using System.ServiceModel;

namespace Biblioteca.utils
{
    public class CepUtils
    {
        private const string CEP_URL = "https://viacep.com.br/ws/{0}/xml/";

        public static Endereco PegarEndereco(string cep)
        {
            //Endereço null = endereço não encontrado
            Endereco endereco = null;

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
            catch (FaultException)
            {
            }

            return endereco;
        }
    }
}
