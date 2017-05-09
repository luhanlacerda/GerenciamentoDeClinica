using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.secretaria
{
    public interface ISecretaria
    {
        //Cadastrar uma secretaria
        void Cadastrar(Secretaria secretaria);
        //Atualizar uma secretaria
        void Atualizar(Secretaria secretaria);
        //Remover uma secretaria
        void Remover(Secretaria secretaria);
        //Selecionar as secretarias que se encaixam no filtro de pesquisa
        List<Secretaria> Listar(Secretaria filtro);
        //Verificar se uma secretaria já está cadastrada
        bool VerificaExistencia(Secretaria secretaria);
    }
}
