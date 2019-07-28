using System;
using System.Collections.Generic;
using System.Text;
using Core.DI;

namespace Core.Interfaces
{
    [AutoDIService(implementationType: "Core.Implementation.UseCaseFactory")]
    public interface IUseCaseFactory
    {
        T Create<T>() where T : UseCase;
    }
}
