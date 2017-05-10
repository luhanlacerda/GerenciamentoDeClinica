using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public interface IEspecialidade
    {
        //Cadastrar uma especialidade
        void Cadastrar(Especialidade especialidade);
        //Atualizar uma especialidade
        void Atualizar(Especialidade especialidade);
        //Remover uma especialidade
        void Remover(Especialidade especialidade);
        //Selecionar as especialidades que se encaixam no filtro de pesquisa
        List<Especialidade> Listar(Especialidade filtro);
        //Verificar se uma especialidade já está cadastrado
        Boolean VerificaExistencia(Especialidade especialidade);
    }
}
