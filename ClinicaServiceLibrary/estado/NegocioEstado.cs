using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaServiceLibrary.utils;

namespace ClinicaServiceLibrary.estado
{
    public class NegocioEstado : IEstado
    {
        public void Cadastrar(Estado estado)
        {
            ClinicaUtils.ValidarVazio(estado.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(estado.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new EstadoBD().Cadastrar(estado);
        }

        public void Atualizar(Estado estado)
        {
            ClinicaUtils.ValidarVazio(estado.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(estado.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new EstadoBD().Atualizar(estado);
        }

        public void Remover(Estado estado)
        {
            ClinicaUtils.ValidarCodigo(estado.ID_Estado);

            new EstadoBD().Remover(estado);
        }

        public List<Estado> Listar(Estado filtro)
        {
            return new EstadoBD().Listar(filtro);
        }

        public bool VerificarExistencia(Estado estado)
        {
            return new EstadoBD().VerificarExistencia(estado);
        }
    }
}
