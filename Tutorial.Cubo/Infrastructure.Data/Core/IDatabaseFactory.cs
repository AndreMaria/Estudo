using Infrastructure.Data.Contexts;
using System;


namespace Infrastructure.Data.Core
{
    public interface IDatabaseFactory : IDisposable
    {
        TutorialContext GetContext();
    }
}
