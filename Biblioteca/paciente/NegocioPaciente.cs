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
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                ClinicaUtils.ValidarPessoa(paciente);

                new PacienteBD().Cadastrar(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(Paciente paciente)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                ClinicaUtils.ValidarPessoa(paciente);

                new PacienteBD().Atualizar(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remover(Paciente paciente)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                new PacienteBD().Remover(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            return new PacienteBD().Listar(filtro);
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                return new PacienteBD().VerificaExistencia(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }



}
