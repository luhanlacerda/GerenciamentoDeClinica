using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Convenio
{
    class Convenio
    {
        private int codigo;
        private String nome;
        private int nrCarteiraSaude;

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public int getNrCarteiraSaude()
        {
            return this.nrCarteiraSaude;
        }

        public void setNrCarteiraSaude(int nrCarteiraSaude)
        {
            this.nrCarteiraSaude = nrCarteiraSaude;
        }
    }
}
