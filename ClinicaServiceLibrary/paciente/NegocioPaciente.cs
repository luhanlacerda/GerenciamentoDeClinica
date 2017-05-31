using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ClinicaServiceLibrary.paciente
{
    public class NegocioPaciente : IPaciente
    {

        public void Cadastrar(Paciente paciente)
        {
            ClinicaUtils.ValidarPessoa(paciente);

            new PacienteBD().Cadastrar(paciente);
        }


        public void Atualizar(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
            ClinicaUtils.ValidarPessoa(paciente);
            
            new PacienteBD().Atualizar(paciente);
        }


        public void Remover(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            new PacienteBD().Remover(paciente);
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            return new PacienteBD().Listar(filtro);
        }

        public bool VerificarExistencia(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            return new PacienteBD().VerificarExistencia(paciente);
        }

    }

}
