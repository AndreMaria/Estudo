using Domain.Cadastro.Commands.UsuarioCommands;
using Domain.Cadastro.DTO;
using Domain.Cadastro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cadastro.Contracts.Services
{
    public interface IUsuarioAppService
    {
        UsuarioDTO ValidarSenha(LoginUsuarioCommand command);
        UsuarioDTO ConsultarPorCodigoIdentificacao(Filters.CredenciadoUsuarioFilter filtro);
        void InsertUsuario(UsuarioDTO usuario);
        List<UsuarioDTO> GetAllUsuario();
        String UpdateUsuario(UsuarioDTO user);
        Usuario GetUsuario(int id);
    }
}
