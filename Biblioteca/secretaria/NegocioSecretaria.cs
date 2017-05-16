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
        public void Atualizar(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
                ClinicaUtils.ValidarPessoa(secretaria);

                new SecretariaBD().Cadastrar(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);
                ClinicaUtils.ValidarPessoa(secretaria);

                new SecretariaBD().Cadastrar(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            return new SecretariaBD().Listar(filtro);
        }

        public void Remover(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                new SecretariaBD().Remover(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaExistencia(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                return new SecretariaBD().VerificaExistencia(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
