using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{
    public interface IPaciente
    {
        //Cadastrar um paciente
        void Cadastrar(Paciente p);
        //Atualizar um paciente
        void Atualizar(Paciente p);
        //Remover um paciente
        void Remover(Paciente p);
        //Devolver os pacientes que se encaixam no filtro de pesquisa
        List<Paciente> Listar(Paciente filtro);
        //Verificar se um paciente já está cadastrado
        Boolean VerificaExistencia(Paciente p);
        //Selecionar paciente
        Paciente SelecionarPaciente(Paciente p); 
    }
}
