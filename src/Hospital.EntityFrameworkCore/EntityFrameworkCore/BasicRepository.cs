using Hospital.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EGAPI.Collaborator.EntityFrameworkCore
{
    public class BasicRepository<TEntity, TKey> : EfCoreRepository<HospitalDbContext, TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        public BasicRepository(IDbContextProvider<HospitalDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
