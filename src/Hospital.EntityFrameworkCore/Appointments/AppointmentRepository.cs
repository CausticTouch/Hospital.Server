using EGAPI.Collaborator.EntityFrameworkCore;
using Hospital.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Hospital.Appointments
{
    public class AppointmentRepository : BasicRepository<Appointment, Guid>, IAppointmentRepository
    {
        public AppointmentRepository(IDbContextProvider<HospitalDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await GetListAsync();
        }
    }
}
