using System.Collections.Generic;

namespace Biblioteca.convenio
{
    public interface IConvenio
    {
        //Cadastrar um médico
        void Cadastrar(Convenio convenio);
        //Atualizar um médico
        void Atualizar(Convenio convenio);
        //Remover um médico
        void Remover(Convenio convenio);
        //Selecionar os médicos que se encaixam no filtro de pesquisa
        List<Convenio> Listar(Convenio filtro);
        //Verificar se um médico já está cadastrado
        bool VerificaExistencia(Convenio convenio);
    }
}
