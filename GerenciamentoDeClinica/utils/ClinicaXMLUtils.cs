using GerenciamentoDeClinica.localhost;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using GerenciamentoDeClinica.Properties;
using GerenciamentoDeClinica.telamedico;

namespace GerenciamentoDeClinica.utils
{
    public class ClinicaXmlUtils
    {
        private static XmlDocument _document;

        private ClinicaXmlUtils()
        {

        }

        public static void Create()
        {
            _document = new XmlDocument();
            CheckExists();
            _document.Load(Properties.Settings.Default.SaveLocation);
        }

        private static void CheckExists()
        {
            if (!File.Exists(Properties.Settings.Default.SaveLocation))
            {
                XmlNode rootNode = _document.CreateElement(Properties.Settings.Default.Root);
                _document.AppendChild(rootNode);
                _document.Save(Properties.Settings.Default.SaveLocation);
            }
        }

        private static XmlNode CheckXmlLoad()
        {
            if (_document == null)
                throw new FaultException("XML não carregado.");
            return _document.SelectSingleNode(Properties.Settings.Default.Root);
        }

        public static void SetPesquisarMedico(PesquisarMedico pesquisarMedico)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode pesquisarMedicoNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (pesquisarMedicoNode != null)
                rootNode.RemoveChild(pesquisarMedicoNode);
            rootNode.InnerXml += ToXml(pesquisarMedico);

            //Recarregar pesquisarMedicoNode
            pesquisarMedicoNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            if (pesquisarMedicoNode != null)
            {
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, seleciona apenas os que tem Name "medicos_salvos" e transforma em List
                List<XmlNode> medicosSalvos = pesquisarMedicoNode.ChildNodes.Cast<XmlNode>()
                    .Where(n => n.Name == Properties.Settings.Default.Pesquisar_Medicos_Salvos).ToList();
                //Início da correção do Xml, onde cada médico salvo estará dentro de "medicos_salvos"
                XmlNode medicosSalvosNode = _document.CreateElement(Properties.Settings.Default.Pesquisar_Medicos_Salvos);
                foreach (XmlNode node in medicosSalvos)
                {
                    //Remove o antigo nó, para haver a troca de nome do nó filho
                    pesquisarMedicoNode.RemoveChild(node);
                    XmlNode newNode = _document.CreateElement(Properties.Settings.Default.Medico);
                    newNode.InnerXml = node.InnerXml;
                    medicosSalvosNode.AppendChild(newNode);
                }

                pesquisarMedicoNode.AppendChild(medicosSalvosNode);
            }

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static PesquisarMedico GetPesquisarMedico()
        {
            XmlNode pesquisarMedicoNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            if (pesquisarMedicoNode == null)
                return null;

            //Retornar para Classe PesquisarMedico, vai haver um erro nos medicos_salvos
            PesquisarMedico pesquisarMedico = FromXml<PesquisarMedico>(pesquisarMedicoNode.OuterXml);
            //Início da correção dos médicos salvos
            XmlNode medicosSalvosNode = pesquisarMedicoNode.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medicos_Salvos);
            if (medicosSalvosNode != null)
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, faz a serialização com cada membro e transforma em List
                pesquisarMedico.MedicosSalvos = medicosSalvosNode.ChildNodes.Cast<XmlNode>()
                    .Select(n => FromXml<Medico>(n.OuterXml)).ToList();

            return pesquisarMedico;
        }

        //Converter medico para xml
        //Flow: XmlSerializer -> XmlWriter -> StringWriter
        public static string ToXml<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();

            /*
             Criará uma variável para escrever um XML, diponível apenas no bloco abaixo.
             Utilizará esta variável para serializar e quando terminar o processo irá finaliza-la.
            */
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter,
                new XmlWriterSettings()
                {
                    OmitXmlDeclaration = true,
                    ConformanceLevel = ConformanceLevel.Auto,
                    Indent = false
                }))
            {
                xmlSerializer.Serialize(xmlWriter, obj);
            }

            return stringWriter.ToString();
        }

        //Transforma um Xml em uma classe tradicional, exemplo de utilização: FromXml<Medico>(variavel);
        public static T FromXml<T>(string xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);

            return (T)xmlSerializer.Deserialize(stringReader);
        }
    }
}
