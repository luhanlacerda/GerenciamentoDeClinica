using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.classesBasicas
{
    abstract class Pessoa
    {
        private String nome { get; set; }
        private String rg { get; set; }
        private String cpf { get; set; }
        private Endereco endereco { get; set; }
    }
}
