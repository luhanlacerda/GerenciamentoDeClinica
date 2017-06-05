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
using GerenciamentoDeClinica.telaconvenio;
using GerenciamentoDeClinica.telapaciente;
using GerenciamentoDeClinica.telasecretaria;

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

        //Medico
        public static CadastrarMedico GetCadastrarMedico()
        {
            XmlNode cadastrarMedicoNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Medico_XPath);
            if (cadastrarMedicoNode == null)
                return null;

            return FromXml<CadastrarMedico>(cadastrarMedicoNode.OuterXml);
        }

        public static void SetCadastrarMedico(CadastrarMedico cadastrarMedico)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode cadastrarMedicoNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Medico_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (cadastrarMedicoNode != null)
                rootNode.RemoveChild(cadastrarMedicoNode);
            rootNode.InnerXml += ToXml(cadastrarMedico);

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static void SetPesquisarMedico(PesquisarMedico pesquisar)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (pesquisarNode != null)
                rootNode.RemoveChild(pesquisarNode);
            rootNode.InnerXml += ToXml(pesquisar);

            //Recarregar pesquisarMedicoNode
            pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            if (pesquisarNode != null)
            {
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, seleciona apenas os que tem Name "medicos_salvos" e transforma em List
                List<XmlNode> salvos = pesquisarNode.ChildNodes.Cast<XmlNode>()
                    .Where(n => n.Name == Properties.Settings.Default.Pesquisar_Medicos_Salvos).ToList();
                //Início da correção do Xml, onde cada médico salvo estará dentro de "medicos_salvos"
                XmlNode salvosNode = _document.CreateElement(Properties.Settings.Default.Pesquisar_Medicos_Salvos);
                foreach (XmlNode node in salvos)
                {
                    //Remove o antigo nó, para haver a troca de nome do nó filho
                    pesquisarNode.RemoveChild(node);
                    XmlNode newNode = _document.CreateElement(Properties.Settings.Default.Medico);
                    newNode.InnerXml = node.InnerXml;
                    salvosNode.AppendChild(newNode);
                }

                pesquisarNode.AppendChild(salvosNode);
            }

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static PesquisarMedico GetPesquisarMedico()
        {
            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medico_XPath);
            if (pesquisarNode == null)
                return null;

            //Retornar para Classe PesquisarMedico, vai haver um erro nos medicos_salvos
            PesquisarMedico pesquisar = FromXml<PesquisarMedico>(pesquisarNode.OuterXml);
            //Início da correção dos médicos salvos
            XmlNode salvosNode = pesquisarNode.SelectSingleNode(Properties.Settings.Default.Pesquisar_Medicos_Salvos);
            if (salvosNode != null)
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, faz a serialização com cada membro e transforma em List
                pesquisar.MedicosSalvos = salvosNode.ChildNodes.Cast<XmlNode>()
                    .Select(n => FromXml<Medico>(n.OuterXml)).ToList();

            return pesquisar;
        }

        //Convenio
        public static void SetCadastrarConvenio(CadastrarConvenio cadastrarConvenio)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode cadastrarConvenioNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Convenio_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (cadastrarConvenioNode != null)
                rootNode.RemoveChild(cadastrarConvenioNode);
            rootNode.InnerXml += ToXml(cadastrarConvenio);

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static void SetPesquisarConvenio(PesquisarConvenio pesquisar)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Convenio_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (pesquisarNode != null)
                rootNode.RemoveChild(pesquisarNode);
            rootNode.InnerXml += ToXml(pesquisar);

            //Recarregar pesquisarMedicoNode
            pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Convenio_XPath);
            if (pesquisarNode != null)
            {
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, seleciona apenas os que tem Name "medicos_salvos" e transforma em List
                List<XmlNode> salvos = pesquisarNode.ChildNodes.Cast<XmlNode>()
                    .Where(n => n.Name == Properties.Settings.Default.Pesquisar_Convenios_Salvos).ToList();
                //Início da correção do Xml, onde cada médico salvo estará dentro de "medicos_salvos"
                XmlNode salvosNode = _document.CreateElement(Properties.Settings.Default.Pesquisar_Convenios_Salvos);
                foreach (XmlNode node in salvos)
                {
                    //Remove o antigo nó, para haver a troca de nome do nó filho
                    pesquisarNode.RemoveChild(node);
                    XmlNode newNode = _document.CreateElement(Properties.Settings.Default.Convenio);
                    newNode.InnerXml = node.InnerXml;
                    salvosNode.AppendChild(newNode);
                }

                pesquisarNode.AppendChild(salvosNode);
            }

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static CadastrarConvenio GetCadastrarConvenio()
        {
            XmlNode cadastrarConvenioNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Convenio_XPath);
            if (cadastrarConvenioNode == null)
                return null;

            return FromXml<CadastrarConvenio>(cadastrarConvenioNode.OuterXml);
        }

        public static PesquisarConvenio GetPesquisarConvenio()
        {
            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Convenio_XPath);
            if (pesquisarNode == null)
                return null;

            //Retornar para Classe PesquisarMedico, vai haver um erro nos medicos_salvos
            PesquisarConvenio pesquisar = FromXml<PesquisarConvenio>(pesquisarNode.OuterXml);
            //Início da correção dos médicos salvos
            XmlNode salvosNode = pesquisarNode.SelectSingleNode(Properties.Settings.Default.Pesquisar_Convenios_Salvos);
            if (salvosNode != null)
                //Pega os nós filhos de medicos salvos, transforma em XmlNode, faz a serialização com cada membro e transforma em List
                pesquisar.ConveniosSalvos = salvosNode.ChildNodes.Cast<XmlNode>()
                    .Select(n => FromXml<Convenio>(n.OuterXml)).ToList();

            return pesquisar;
        }

        //Paciente
        public static CadastrarPaciente GetCadastrarPaciente()
        {
            XmlNode cadastrarPacienteNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Paciente_XPath);
            if (cadastrarPacienteNode == null)
                return null;

            return FromXml<CadastrarPaciente>(cadastrarPacienteNode.OuterXml);
        }

        public static void SetCadastrarPaciente(CadastrarPaciente cadastrarPaciente)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode cadastrarPacienteNode = _document.SelectSingleNode(Properties.Settings.Default.Cadastrar_Paciente_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (cadastrarPacienteNode != null)
                rootNode.RemoveChild(cadastrarPacienteNode);
            rootNode.InnerXml += ToXml(cadastrarPaciente);

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static void SetPesquisarPaciente(PesquisarPaciente pesquisar)
        {
            XmlNode rootNode = CheckXmlLoad();

            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Paciente_XPath);
            //Se existir, remover para a inserção do novo Xml
            if (pesquisarNode != null)
                rootNode.RemoveChild(pesquisarNode);
            rootNode.InnerXml += ToXml(pesquisar);

            //Recarregar pesquisarPacienteNode
            pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Paciente_XPath);
            if (pesquisarNode != null)
            {
                /*Pega os nós filhos de pacientes salvos, transforma em XmlNode, seleciona apenas
                os que tem Name "pacientes_salvos" e transforma em List*/
                List<XmlNode> salvos = pesquisarNode.ChildNodes.Cast<XmlNode>()
                    .Where(n => n.Name == Properties.Settings.Default.Pesquisar_Pacientes_Salvos).ToList();
                //Início da correção do Xml, onde cada paciente salvo estará dentro de "paciente_salvos"
                XmlNode salvosNode = _document.CreateElement(Properties.Settings.Default.Pesquisar_Pacientes_Salvos);
                foreach (XmlNode node in salvos)
                {
                    //Remove o antigo nó, para haver a troca de nome do nó filho
                    pesquisarNode.RemoveChild(node);
                    XmlNode newNode = _document.CreateElement(Properties.Settings.Default.Paciente);
                    newNode.InnerXml = node.InnerXml;
                    salvosNode.AppendChild(newNode);
                }

                pesquisarNode.AppendChild(salvosNode);
            }

            _document.Save(Properties.Settings.Default.SaveLocation);
        }

        public static PesquisarPaciente GetPesquisar()
        {
            XmlNode pesquisarNode = _document.SelectSingleNode(Properties.Settings.Default.Pesquisar_Paciente_XPath);
            if (pesquisarNode == null)
                return null;

            //Retornar para Classe PesquisarPacientes, vai haver um erro nos pacientes_salvos
            PesquisarPaciente pesquisar = FromXml<PesquisarPaciente>(pesquisarNode.OuterXml);
            //Início da correção dos pacientes salvos
            XmlNode salvosNode = pesquisarNode.SelectSingleNode(Properties.Settings.Default.Pesquisar_Pacientes_Salvos);
            if (salvosNode != null)
                //Pega os nós filhos de pacientes salvos, transforma em XmlNode, faz a serialização com cada membro e transforma em List
                pesquisar.PacientesSalvos = salvosNode.ChildNodes.Cast<XmlNode>()
                    .Select(n => FromXml<Paciente>(n.OuterXml)).ToList();

            return pesquisar;
        }

        //Secretaria

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
