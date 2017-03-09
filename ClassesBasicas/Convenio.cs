using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesBasicas
{
    public class Convenio
    {
        private int codigo;
        private String nome;
        private int nrCarteiraSaude;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int NrCarteiraSaude
        {
            get
            {
                return nrCarteiraSaude;
            }

            set
            {
                nrCarteiraSaude = value;
            }
        }
    }
}
