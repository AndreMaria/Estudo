using Domain.Cadastro.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cadastro.Commands.UsuarioCommands
{
    public class LoginUsuarioCommand
    {
        public virtual string CodigoUsuario { get; set; }
        public virtual string Senha { get; set; }

        //public virtual void Validar(IUsuarioRepository usuarioRepository, IPerfilUsuarioRepository perfilUsuarioRepository)
        //{
        //    //var validator = new MigracaoDadosUsuarioValidator(usuarioRepository, perfilUsuarioRepository);
        //    //validator.ValidateAndThrow(this);
        //}
    }
}
