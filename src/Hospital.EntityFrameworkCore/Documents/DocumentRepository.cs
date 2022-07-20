using EGAPI.Collaborator.EntityFrameworkCore;
using Hospital.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Hospital.Documents
{
    public class DocumentRepository : BasicRepository<Document, Guid>, IDocumentRepository
    {
        public DocumentRepository(IDbContextProvider<HospitalDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<IEnumerable<Document>> GetAllAsync()
        {
            return await GetListAsync();
        }
    }
}
