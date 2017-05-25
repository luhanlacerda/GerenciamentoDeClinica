using System.Collections.Generic;

namespace Biblioteca.paciente
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
