using Hospital.Usrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Hospital.User
{
    public class UsrAppService : ApplicationService, IUsrAppService
    {
        private readonly IUsrRepository _usrRepository;
        public UsrAppService(IUsrRepository usrRepository)
        {
            _usrRepository = usrRepository;
        }

        public async Task<List<UsrDto>> GetListOfUsers()
        {
            var list = await _usrRepository.GetListAsync();

            return list
                .OrderBy(x => x.Email)
                .Select(x => ObjectMapper.Map<Usr, UsrDto>(x))
                .ToList();
        }
        public async Task<UsrDto> CreateAsync(CreateUsrDto input)
        {
            if (input == null)
                return null;

            var usr = new Usr(email: input.Email,
                              password: input.Password,
                              gender: input.Gender,
                              firstName: input.FirstName,
                              lastName: input.LastName,
                              dateBirth: input.DateBirth,
                              phone: input.Phone,
                              nationality: input.Nationality,
                              ocupation: input.Ocupation,
                              address: input.Address,
                              postCode: input.PostCode,
                              height: input.Height,
                              weight: input.Weight);

            await _usrRepository.InsertAsync(usr, autoSave: true);

            return ObjectMapper.Map<Usr, UsrDto>(usr);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _usrRepository.DeleteAsync(id);
        }
    }
}
