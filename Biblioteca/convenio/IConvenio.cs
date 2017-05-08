using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{
    public interface IConvenio
    {
        //Cadastrar um convenio
        void Cadastrar(Convenio c);
        //Atualizar um convenio
        void Atualizar(Convenio c);
        //Remover um convenio
        void Remover(Convenio c);
        //Devolver os convenios que se encaixam no filtro de pesquisa
        List<Convenio> Listar(Convenio filtro);
        //Verificar se um convenio já está cadastrado
        Boolean VerificaExistencia (Convenio c);
    }
}
