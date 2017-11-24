using AppService.Cadastro;
using Domain.Cadastro.Contracts.Repositories;
using Domain.Cadastro.DTO;
using Extensions;
using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Test.Cadastro.Usuario
{
    public class UpdateUsuarioTests
    {
        public void UpdateUsuario_UsuarioNulo
        (
            [Frozen] Moq.Mock<IUsuarioRepository> _mockUsuarioRepository,
            [Frozen] Moq.Mock<UsuarioDTO> _mockUsuarioDTO,
            UsuarioAppService sut
        )
        {
            var usuario = sut.UpdateUsuario(null);
            Xunit.Assert.Null(usuario);
        }

        public void UpdateUsuario_Success
        (
            [Frozen] Moq.Mock<IUsuarioRepository> _mockUsuarioRepository,
            [Frozen] Moq.Mock<UsuarioDTO> _mockUsuarioDTO,
            UsuarioAppService sut
        )
        {
            _mockUsuarioDTO.Object.Email = DataGenerator.RandomString(250);
            _mockUsuarioDTO.Object.Nome = DataGenerator.RandomString(250);
            _mockUsuarioDTO.Object.Senha = DataGenerator.RandomString(250);

            var usuario = sut.UpdateUsuario(_mockUsuarioDTO.Object);
            Xunit.Assert.Null(usuario);
        }
    }
}
