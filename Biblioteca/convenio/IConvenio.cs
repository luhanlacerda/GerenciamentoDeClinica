using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.convenio
{
    public interface IConvenio
    {
        //Cadastrar um convenio
        void Cadastrar(Convenio convenio);
        //Atualizar um convenio
        void Atualizar(Convenio convenio);
        //Remover um convenio
        void Remover(Convenio convenio);
        //Selecionar os convenios que se encaixam no filtro de pesquisa
        List<Convenio> Listar(Convenio filtro);
        //Verificar se um convenio já está cadastrado
        Boolean VerificaExistencia(Convenio convenio);
    }
}
