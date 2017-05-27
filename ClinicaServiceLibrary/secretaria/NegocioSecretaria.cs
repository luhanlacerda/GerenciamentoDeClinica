using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.secretaria
{
    public class NegocioSecretaria : ISecretaria
    {
        public void Atualizar(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
            ClinicaUtils.ValidarPessoa(secretaria);

            new SecretariaBD().Cadastrar(secretaria);
        }

        public void Cadastrar(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
            ClinicaUtils.ValidarPessoa(secretaria);

            new SecretariaBD().Cadastrar(secretaria);
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            return new SecretariaBD().Listar(filtro);
        }

        public void Remover(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

            new SecretariaBD().Remover(secretaria);
        }

        public bool VerificarExistencia(Secretaria secretaria)
        {
            ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

            return new SecretariaBD().VerificarExistencia(secretaria);
        }
    }
}
