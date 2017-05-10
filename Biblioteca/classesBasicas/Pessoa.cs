using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Pessoa : Endereco
    {
        public String Nome { get; set; }
        public String RG { get; set; }
        public String CPF { get; set; }
        public string Endereco { get; set; }
        public String Celular { get; set; }
        public DateTime DtNascimento { get; set; }
        public String Email { get; set; }
        public String Estado_Civil { get; set; }
    }
}
