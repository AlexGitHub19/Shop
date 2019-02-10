using System;

namespace Shop.DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create();
    }
}
