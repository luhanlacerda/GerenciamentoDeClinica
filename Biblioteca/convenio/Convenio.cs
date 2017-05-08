using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.convenio
{
    public class Convenio
    {
        private int id_convenio;
        private String descricao;

        public int Id_convenio
        {
            get { return id_convenio; }
            set { id_convenio = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


    }
}

