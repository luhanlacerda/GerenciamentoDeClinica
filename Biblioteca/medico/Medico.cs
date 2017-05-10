using Biblioteca.especialidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{

    public class Medico : classesBasicas.Pessoa
    {
        private int crm;
        private Especialidade especialidade; //vai usar o código da especialidade
        //tes1
        public int Crm
        {
            get
            {
                return crm;
            }

            set
            {
                crm = value;
            }
        }

        public Especialidade Especialidade
        {
            get
            {
                return especialidade;
            }

            set
            {
                especialidade = value;
            }
        }
        public String MedicoToString()
        {
            String retorno;
            retorno = "Nome: " + this.Nome + "\n";
            retorno += "CRM: " + this.Crm + "\n";
            retorno += "Especialidade: " + this.Especialidade.Descricao;
            return retorno;
        }
    }
}
