using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IUseCaseFactory
    {
        T Create<T>() where T : UseCase;
    }
}
