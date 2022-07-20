using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hospital.Appointments
{
    public class AppointmentAppService : ApplicationService, IAppointmentAppService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentAppService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<AppointmentDto> CreateAsync(CreateAppointmentDto input)
        {
            if (input == null)
                return null;

            var appointment = new Appointment(name: input.Name,
                                              dr: input.Dr,
                                              date: input.Date,
                                              time: input.Time,
                                              description: input.Description); 

            await _appointmentRepository.InsertAsync(appointment, autoSave: true);

            return ObjectMapper.Map<Appointment, AppointmentDto>(appointment);
        }

        public async Task<List<AppointmentDto>> GetAll()
        {
            var list = await _appointmentRepository.GetAllAsync();
            return list.Select(x => ObjectMapper.Map<Appointment, AppointmentDto>(x)).ToList();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _appointmentRepository.DeleteAsync(id);
        }
    }
}
