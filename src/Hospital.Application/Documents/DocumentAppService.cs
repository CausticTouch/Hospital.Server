using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hospital.Documents
{
    public class DocumentAppService : ApplicationService, IDocumentAppService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentAppService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task<DocumentDto> CreateAsync(CreateDocumentDto input)
        {
            if (input == null)
                return null;

            var document = new Document(firstName: input.FirstName,
                lastName: input.LastName,
                email: input.Email,
                phoneNumber: input.PhoneNumber,
                patientInfo: input.PatientInfo,
                desc: input.Desc);

            await _documentRepository.InsertAsync(document, autoSave: true);

            return ObjectMapper.Map<Document, DocumentDto>(document);
        }

        public async Task<List<DocumentDto>> GetAll()
        {
            var list = await _documentRepository.GetAllAsync();
            return list.Select(x => ObjectMapper.Map<Document, DocumentDto>(x)).ToList();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _documentRepository.DeleteAsync(id);
        }
    }
}
