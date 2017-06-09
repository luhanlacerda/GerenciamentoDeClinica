using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Atendimento.utils
{
    public class ClinicaXmlUtils
    {
        private ClinicaXmlUtils()
        {

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
