using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories.Styles
{
    public interface IStyleRepository : IRepository<Style>
    {
        Task<IEnumerable<Style>> GetCustomStyles(bool customStyle);
        Task<IEnumerable<Style>> GetStylesWithServices(int pageIndex, int pageSize);
    }
}
