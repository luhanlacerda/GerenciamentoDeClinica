using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    public interface IPaciente
    {
        //Cadastrar um paciente
        void Cadastrar(Paciente paciente);
        //Atualizar um paciente
        void Atualizar(Paciente paciente);
        //Remover um paciente
        void Remover(Paciente paciente);
        //Selecionar os paciente que se encaixam no filtro de pesquisa
        List<Paciente> Listar(Paciente filtro);
        //Verificar se um paciente já está cadastrado
        bool VerificaExistencia(Paciente paciente); 
    }
}
