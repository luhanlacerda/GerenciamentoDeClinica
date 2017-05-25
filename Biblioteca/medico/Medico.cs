using Biblioteca.classesBasicas;
using Biblioteca.especialidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca.medico
{

    public class Medico : Pessoa
    {
        public int ID_Medico { get; set; }
        public string CRM { get; set; }
        public Especialidade Especialidade { get; set; }

        //Converter medico para xml
        //Flow: XmlSerializer -> XmlWriter -> StringWriter
        public string ToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(GetType());
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
                xmlSerializer.Serialize(xmlWriter, this);
            }

            return stringWriter.ToString();
        }
    }
}
