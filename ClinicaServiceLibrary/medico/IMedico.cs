using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.medico
{
    public interface IMedico
    {
        //Cadastrar um médico
        void Cadastrar(Medico medico);
        //Atualizar um médico
        void Atualizar(Medico medico);
        //Remover um médico
        void Remover(Medico medico);
        //Selecionar os médicos que se encaixam no filtro de pesquisa
        List<Medico> Listar(Medico filtro);
        //Verificar se um médico já está cadastrado
        bool VerificarExistencia(Medico medico); //Qual a diferença de bool para Boolean?
    }
}
