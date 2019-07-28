using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Repositories.Styles;
using Core.DI;

namespace Repositories
{
    [AutoDIService(implementationType: "Repositories.UnitOfWork")]
    public interface IUnitOfWork : IDisposable
    {
        IStyleRepository Styles { get; }
        Task<int> Complete();
    }
}
