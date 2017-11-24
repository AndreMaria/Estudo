
using System;

namespace Common
{
    public interface IDatabaseFactory<U>:IDisposable
    {
        Context<U> GetContext();
    }
}
