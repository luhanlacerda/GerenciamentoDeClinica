using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.usuario
{
    public class NegocioUsuario : IUsuario
    {
        public void Cadastrar(Usuario usuario)
        {
            ClinicaUtils.ValidarPessoa(usuario);

            new UsuarioBD().Cadastrar(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            ClinicaUtils.ValidarCodigo(usuario.ID_Usuario);
            ClinicaUtils.ValidarPessoa(usuario);

            new UsuarioBD().Atualizar(usuario);
        }

        public void Remover(Usuario usuario)
        {
            ClinicaUtils.ValidarCodigo(usuario.ID_Usuario);

            new UsuarioBD().Remover(usuario);
        }

        public List<Usuario> Listar(Usuario filtro)
        {
            return new UsuarioBD().Listar(filtro);
        }

        public bool VerificarExistencia(Usuario usuario)
        {
            ClinicaUtils.ValidarCodigo(usuario.ID_Usuario);
            return new UsuarioBD().VerificarExistencia(usuario);
        }
    }
}
