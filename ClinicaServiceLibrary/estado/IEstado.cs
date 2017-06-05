using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.estado
{
    public interface IEstado
    {
        //Cadastrar um médico
        void Cadastrar(Estado estado);
        //Atualizar um médico
        void Atualizar(Estado estado);
        //Remover um médico
        void Remover(Estado estado);
        //Selecionar os médicos que se encaixam no filtro de pesquisa
        List<Estado> Listar(Estado filtro);
        //Verificar se um médico já está cadastrado
        bool VerificarExistencia(Estado estado);
    }
}
