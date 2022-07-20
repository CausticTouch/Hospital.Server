using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hospital.Documents
{
    public interface IDocumentAppService : IApplicationService
    {
        Task<List<DocumentDto>> GetAll();
        Task<DocumentDto> CreateAsync(CreateDocumentDto input);
    }
}
