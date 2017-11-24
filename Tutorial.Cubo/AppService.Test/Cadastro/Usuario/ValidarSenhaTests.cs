using AppService.Cadastro;
using Domain.Cadastro.Contracts.Repositories;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AppService.Test.Cadastro.Usuario
{
    public class ValidarSenhaTests
    {
        private readonly Mock<IUsuarioRepository> _mockUsuarioRepository;
        private readonly UsuarioAppService _sut;

        public ValidarSenhaTests
        (
            [Frozen] Mock<IUsuarioRepository> mockUsuarioRepository,
            UsuarioAppService sut
        )
        {

        }


    }
}
