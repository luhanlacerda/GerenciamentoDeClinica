﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca.especialidade
{
    public class Especialidade
    {
        public int ID_Especialidade { get; set; }
        public String Descricao { get; set; }

        //Converter cliente para xml
        //Flow: XmlSerializer -> XmlWriter -> StringWriter
        public string ToXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(GetType());
            StringWriter stringWriter = new StringWriter();

            /*
             Criará uma variável para escrever um XML, diponível apenas no bloco abaixo.
             Utilizará esta variável para serializar e quando terminar o processo irá finaliza-la.
            */
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
            {
                xmlSerializer.Serialize(xmlWriter, this);
            }

            return stringWriter.ToString();
        }

    }

}
