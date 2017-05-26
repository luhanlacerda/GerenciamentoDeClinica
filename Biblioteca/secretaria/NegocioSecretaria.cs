using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.secretaria
{
    public class NegocioSecretaria : ISecretaria
    {
        public void AtualizarSecretaria(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
            ClinicaUtils.ValidarPessoa(secretaria);

            new SecretariaBD().CadastrarSecretaria(secretaria);
        }

        public void CadastrarSecretaria(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
            ClinicaUtils.ValidarPessoa(secretaria);

            new SecretariaBD().CadastrarSecretaria(secretaria);
        }

        public List<Secretaria> ListarSecretaria(Secretaria filtro)
        {
            return new SecretariaBD().ListarSecretaria(filtro);
        }

        public void RemoverSecretaria(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

            new SecretariaBD().RemoverSecretaria(secretaria);
        }

        public bool VerificarExistenciaSecretaria(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

            return new SecretariaBD().VerificarExistenciaSecretaria(secretaria);
        }
    }
}
