using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    public class NegocioMedico : IMedico
    {

        public void Cadastrar(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);
            ClinicaUtils.ValidarPessoa(medico);

            new MedicoBD().Cadastrar(medico);
        }

        public void Atualizar(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);
            ClinicaUtils.ValidarPessoa(medico);

            new MedicoBD().Atualizar(medico);
        }

        public void Remover(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);

            new MedicoBD().Remover(medico);
        }

        public List<Medico> Listar(Medico filtro)
        {
            return new MedicoBD().Listar(filtro);
        }

        public bool VerificaExistencia(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);

            return new MedicoBD().VerificaExistencia(medico);
        }
    }
}
