using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.classesBasicas
{
    abstract class Endereco
    {
        private String logradouro { get; set; }
        private String numero { get; set; }
        private String complemento { get; set; }
        private String bairro { get; set; }
        private String cidade { get; set; }
        private String uf { get; set; }
        private String cep { get; set; }
        private String pais { get; set; }
    }
}
