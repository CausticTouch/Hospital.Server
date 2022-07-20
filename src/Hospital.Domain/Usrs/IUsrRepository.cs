using Hospital.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Hospital.Usrs
{
    public interface IUsrRepository : IRepository<Usr, Guid>
    {
        Task<IEnumerable<Usr>> GetAllAsync();
    }
}
