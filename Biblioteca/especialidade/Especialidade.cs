
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public class Especialidade
    {
        private int id_especialidade;
        private String descricao;

        public int Id_especialidade
        {
            get { return id_especialidade; }
            set { id_especialidade = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
