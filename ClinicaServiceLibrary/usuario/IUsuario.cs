using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.usuario
{
    
    public interface IUsuario
    {
        void Cadastrar(Usuario usuario);
        void Remover(Usuario usuario);
        void Atualizar(Usuario usuario);
        List<Usuario> Listar(Usuario filtro);
        bool VerificarExistencia(Usuario usuario);

    }
}
