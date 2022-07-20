using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Hospital.Usrs
{
    public interface IUsrAppService : IApplicationService
    {
        Task<List<UsrDto>> GetListOfUsers();
    }
}
