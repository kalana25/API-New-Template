using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IStyleRepository : IRepository<Style>
    {
        Task<IEnumerable<Style>> GetCustomStyles(bool customStyle);
        Task<IEnumerable<Style>> GetStylesWithServices(int pageIndex, int pageSize);
    }
}
