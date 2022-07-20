using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hospital.Appointments
{
    public interface IAppointmentAppService : IApplicationService
    {
        Task<List<AppointmentDto>> GetAll();
        Task<AppointmentDto> CreateAsync(CreateAppointmentDto input);
        Task DeleteAsync(Guid id);
    }
}
