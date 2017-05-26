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

        public void CadastrarMedico(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);
            ClinicaUtils.ValidarPessoa(medico);

            new MedicoBD().CadastrarMedico(medico);
        }

        public void AtualizarMedico(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);
            ClinicaUtils.ValidarPessoa(medico);

            new MedicoBD().AtualizarMedico(medico);
        }

        public void RemoverMedico(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);

            new MedicoBD().RemoverMedico(medico);
        }

        public List<Medico> ListarMedico(Medico filtro)
        {
            return new MedicoBD().ListarMedico(filtro);
        }

        public bool VerificarExistenciaMedico(Medico medico)
        {
            ClinicaUtils.ValidarCodigo(medico.ID_Medico);

            return new MedicoBD().VerificarExistenciaMedico(medico);
        }
    }
}
