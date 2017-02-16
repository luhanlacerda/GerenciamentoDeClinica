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
        private String rua { get; set; }
        private String numeroResidencia { get; set; }
        private String complemento { get; set; }
        private String bairro { get; set; }
        private String cidade { get; set; }
        private String uf { get; set; }
        private String país { get; set; }

    }
}
