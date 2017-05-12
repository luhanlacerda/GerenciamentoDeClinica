using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.consulta
{
    public interface IConsulta
    {
        //Cadastrar Consulta
        void Cadastrar (Consulta consulta);
        //Atualizar Consulta
        void Atualizar(Consulta consulta);
        //Remover Consulta
        void Remover(Consulta consulta);
        //Selecionando as consultas que se encaixam no filtro
        List<Consulta> Listar(Consulta filtro);
        //Vereficar se uma consulta ja está cadastrado
        bool VerificarExistencia(Consulta consulta);
    }
}
