using AppService.Cadastro;
using Domain.Cadastro.Contracts.Repositories;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AppService.Test.Cadastro.Usuario
{
    public class GetAllUsuarioTests
    {
        public void Get_All_Usuario_Success
        (
            [Frozen] Mock<IUsuarioRepository> mockUsuarioRepository,
            UsuarioAppService sut
        )
        {
            //arrange

            //act
            sut.GetAllUsuario();

            //assert
            mockUsuarioRepository.Verify(v => v.GetAllUsuario(), Times.Once());
        }
    }
}
