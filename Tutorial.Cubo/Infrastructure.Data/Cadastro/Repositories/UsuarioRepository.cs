using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Cadastro.Entities;
using Domain.Cadastro.Contracts;
using Infrastructure.Data.Contexts;
using Domain.Cadastro.Contracts.Repositories;
using Domain.Cadastro.Filters;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq.Expressions;
using Infrastructure.Data.Core;

namespace Infrastructure.Data.Cadastro.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository()
        {

        }

        public Usuario ConsultarPorCodigoIdentificacao(CredenciadoUsuarioFilter filtro)
        {
            Expression<Func<Usuario, bool>> filter = x => x.Id == filtro.Codigo;

           return base.FirstOrDefault(filter);
        }

        public Usuario ValidarSenha(string codigoUsuario, string senha)
        {
            Usuario result = null;

            Expression<Func<Usuario, bool>> filter = x => x.Email == codigoUsuario && x.Senha == senha;
            result = FirstOrDefault(filter);
            
            return result;
        }

        public void InsertUsuario(Usuario usuario)
        {
            try
            {
                Add(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetAllUsuario()
        {
            return FindAll();
        }

        public String UpdateUsuario(Usuario user)
        {
            String result = String.Empty;
            try
            {
                Update(user);
                result = String.Format("Usuário atualizado com sucesso! {0}", DateTime.Now);
            }
            catch (Exception ex)
            {
                result = String.Format("Erro {0} Data{1}",ex.Message, DateTime.Now);
            }
            return result;
        }

        public Usuario GetUsuario(int id)
        {
            Expression<Func<Usuario, bool>> filter = x => x.Id == id;
            return FirstOrDefault(filter);
        }
    }
}
