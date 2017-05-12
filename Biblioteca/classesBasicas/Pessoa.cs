using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Pessoa
    {
        public String Nome            { get; set; }
        public String RG              { get; set; }
        public String CPF             { get; set; }
        public Endereco Endereco      { get; set; }
        public String Contato         { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public String Email           { get; set; }
        public String Estado_Civil    { get; set; }

        public Pessoa()
        {
            Endereco = new Endereco();
        }
    }
}
