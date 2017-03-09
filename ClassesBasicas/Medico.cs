using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesBasicas
{

    public class Medico : Pessoa
    {
        private int crm;
        private Especialidade especialidade; //vai usar o código da especialidade

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
        public String toString()
        {
            String retorno;
            retorno = "Nome: " + this.Nome + "\n";
            retorno += "CRM: " + this.Crm + "\n";
            retorno += "Especialidade: " + this.Especialidade.Descricao;
            return retorno;
        }
    }
}
