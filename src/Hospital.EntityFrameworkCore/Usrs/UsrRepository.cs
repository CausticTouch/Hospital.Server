using EGAPI.Collaborator.EntityFrameworkCore;
using Hospital.EntityFrameworkCore;
using Hospital.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Hospital.Usrs
{
    internal class UsrRepository : BasicRepository<Usr, Guid>, IUsrRepository
    {
        public UsrRepository(IDbContextProvider<HospitalDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<IEnumerable<Usr>> GetAllAsync()
        {
            return await GetListAsync();
        }
    }
}
