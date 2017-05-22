using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    public class NegocioPaciente : IPaciente
    {

        public void Cadastrar(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
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

        public bool VerificaExistencia(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
            return new PacienteBD().VerificaExistencia(paciente);
        }
    }



}
