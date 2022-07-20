using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hospital.Appointments
{
    public class AppointmentDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Dr { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
