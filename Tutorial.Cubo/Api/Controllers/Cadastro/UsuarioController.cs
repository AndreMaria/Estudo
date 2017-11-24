using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using Domain.Cadastro.Contracts.Services;
using Api.Models;
using Domain.Cadastro.Commands.UsuarioCommands;
using Domain.Cadastro.DTO;

namespace Api.Controllers.Cadastro
{
    [RoutePrefix("api")]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(UsuarioModel))]
        [HttpPost]
        [Route("usuarios/migracao")]
        public IHttpActionResult ValidarSenha([FromBody] LoginUsuarioCommand command)
        {
            UsuarioModel u = null;
            if (null == command)
            {
                return BadRequest();
            }

            var dadosUsuario = _usuarioAppService.ValidarSenha(command);

            if (null == dadosUsuario)
            {
                return NotFound();
            }
            else {
                u = new UsuarioModel();
                u.Id = dadosUsuario.Id;
                u.Nome = dadosUsuario.Nome;
                u.Email = dadosUsuario.Email;
            }
            return Ok(dadosUsuario);
        }

        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(String))]
        [HttpPost]
        [Route("usuarios/Inserts")]
        public IHttpActionResult InsertUsuario([FromBody] UsuarioModel command)
        {
            UsuarioModel u = null;
            if (null == command)
            {
                return BadRequest();
            }
            Domain.Cadastro.DTO.UsuarioDTO user = new Domain.Cadastro.DTO.UsuarioDTO();
            user.Nome = command.Nome;
            user.Email = command.Email;
            user.Senha = command.Senha;

            _usuarioAppService.InsertUsuario(user);

            return Ok("Processo realizado com sucesso");

        }

        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(String))]
        [HttpPost]
        [Route("usuarios/Update")]
        public IHttpActionResult UpdateUsuario([FromBody] UsuarioModel command)
        {
            UsuarioModel u = null;
            if (null == command)
            {
                return BadRequest();
            }
            Domain.Cadastro.DTO.UsuarioDTO user = new Domain.Cadastro.DTO.UsuarioDTO();
            user.Id = command.Id;
            user.Nome = command.Nome;
            user.Email = command.Email;
            user.Senha = command.Senha;

            String result = _usuarioAppService.UpdateUsuario(user);

            return Ok(result);

        }

        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(UsuarioModel))]
        [HttpGet]
        [Route("usuarios/GetAllUsuario")]
        public IHttpActionResult GetAllUsuario()
        {
            List<UsuarioModel> users = null;
            var list = new List<UsuarioDTO>();

            list.Add(new UsuarioDTO() { Id = 1, Nome = "Andre Maria", Email = "andremaria1980@gmail.com ", Senha = "123456" });
            list.Add(new UsuarioDTO() { Id = 1, Nome = "Joaquim Maria", Email = "joaquimmaria2015@gmail.com ", Senha = "123456" });
            list.Add(new UsuarioDTO() { Id = 1, Nome = "Francisco Maria", Email = "franciscomaria2017@gmail.com ", Senha = "123456" });
            //this._usuarioAppService.GetAllUsuario();
            if (null != list && list.Count > 0)
            {
                users = new List<UsuarioModel>();
                foreach (var item in list)
                {
                    users.Add(new UsuarioModel() { Id = Convert.ToInt32(item.Id), Nome = item.Nome, Email = item.Email, Senha = item.Senha });
                }
                //Mega oMega = new Mega();
                //var listMega = oMega.getList();

                //var listAll = oMega.GetAll();//.GroupBy(x => new { x }).Select(y => y.FirstOrDefault());
                //var result = listAll.GroupBy(x => x)
                //    .OrderByDescending(x => x.Count())
                //    .Select(n => new { Numero = n.Key, Vezes = n.Count() }).ToList();

                //var listEsta = oMega.GetSorteios();

                //var novosSorteios = oMega.NovoSorteio();

                //var teste = oMega.GetTop20();

                //var teste2 = oMega.GerarSorteioTop10();
            }
            return Ok(users);
        }

        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(404, "NotFound")]
        [SwaggerResponse(200, "Ok", typeof(UsuarioModel))]
        [HttpGet]
        [Route("usuarios/GetUsuarioById")]
        public IHttpActionResult GetUsuarioById(int id)
        {
            UsuarioModel user = null;
            var item = this._usuarioAppService.GetUsuario(id);
            user = new UsuarioModel();
            user.Id = Convert.ToInt32(item.Id);
            user.Nome = item.Nome;
            user.Email = item.Email;
            user.Senha = item.Senha ;

            return Ok(user);
        }
    }
}
