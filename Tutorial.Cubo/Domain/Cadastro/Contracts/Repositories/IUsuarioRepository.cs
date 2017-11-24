using Domain.Cadastro.Entities;
using System;

namespace Domain.Cadastro.Contracts.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Usuario ValidarSenha(string codigoUsuario, string senha);
        Usuario ConsultarPorCodigoIdentificacao(Filters.CredenciadoUsuarioFilter filtro);
        void InsertUsuario(Usuario usuario);
        System.Collections.Generic.List<Usuario> GetAllUsuario();
        String UpdateUsuario(Usuario user);
        Usuario GetUsuario(int id);
    }
}
