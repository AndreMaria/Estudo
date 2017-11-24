using Domain.Cadastro.Contracts.Services;
using System;
using Domain.Cadastro.Filters;
using Domain.Cadastro.Commands.UsuarioCommands;
using Domain.Cadastro.Contracts.Repositories;
using Domain.Cadastro.DTO;
using Domain.Cadastro.Entities;
using System.Collections.Generic;

namespace AppService.Cadastro
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioAppService(IUsuarioRepository usuarioRepository) {
            this._usuarioRepository = usuarioRepository;
        }

        public UsuarioDTO ConsultarPorCodigoIdentificacao(CredenciadoUsuarioFilter filtro)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO ValidarSenha(LoginUsuarioCommand command)
        {
            var usuario = this._usuarioRepository.ValidarSenha(command.CodigoUsuario, command.Senha);
            var user = new UsuarioDTO();
            if (null != usuario)
            {
                user.Id = Convert.ToInt32(usuario.Id);
                user.Nome = usuario.Nome;
                user.Email = usuario.Email;
            }

            return user;
        }

        public void InsertUsuario(UsuarioDTO usuario)
        {
            Usuario user = new Usuario();
            user.Nome = usuario.Nome;
            user.Email = usuario.Email;
            user.Senha = usuario.Senha;
            this._usuarioRepository.InsertUsuario(user);
        }

        public List<UsuarioDTO> GetAllUsuario()
        {
            List<UsuarioDTO> result = null;
            var list = this._usuarioRepository.GetAllUsuario();
            if (null != list && list.Count > 0)
            {
                result = new List<UsuarioDTO>();
                foreach (var item in list)
                {
                    result.Add(new UsuarioDTO() { Id = Convert.ToInt32(item.Id), Nome = item.Nome, Email = item.Email, Senha = item.Senha });
                }
            }
            return result;
        }

        public String UpdateUsuario(UsuarioDTO usuario)
        {
            if (null != usuario)
                return String.Format("Os dados do usuário não pode ser nullo!");

            Usuario user = new Usuario();
            user.Id = usuario.Id;
            user.Nome = usuario.Nome;
            user.Email = usuario.Email;
            user.Senha = usuario.Senha;
            return this._usuarioRepository.UpdateUsuario(user);
        }

        public Usuario GetUsuario(int id)
        {
            return this._usuarioRepository.GetUsuario(id);
        }
    }
}
