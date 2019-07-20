using System;
using System.Collections.Generic;
using System.Text;
using Core.Repositories;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IStyleRepository Styles { get; }
        Task<int> Complete();
    }
}
