using AppService.Cadastro;
using Domain.Cadastro.Contracts.Repositories;
using Domain.Cadastro.DTO;
using Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AppService.Test.Cadastro.Usuario
{
    public class GetUsuarioTests
    {
        private const int ID_ZERO = 0;
        private const int ID_INVALIDO = 12456;

        private readonly Mock<IUsuarioRepository> _mockUsuarioRepository;
        private readonly Mock<UsuarioDTO> _mockUsuarioDTO;
        private readonly UsuarioAppService _sut;

        public GetUsuarioTests()
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            _mockUsuarioDTO = fixture.Freeze<Mock<UsuarioDTO>>();
            _mockUsuarioRepository = fixture.Freeze<Mock<IUsuarioRepository>>();
            _sut = fixture.Freeze<UsuarioAppService>();
        }

        [Theory, AutoMoqData]
        public void GetUsuario_Success(int id)
        {
            // arrange

            // act
            _sut.GetUsuario(id);

            // assert
            Xunit.Assert.True(true);
        }

        [Theory, AutoMoqData]
        public void GetUsuario_Success_IdZerro(int id)
        {
            // arrange

            // act
            _sut.GetUsuario(0);
            // assert
            Xunit.Assert.True(true);
        }

    }
}
