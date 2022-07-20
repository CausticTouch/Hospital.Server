using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Appointments
{
    public class UpdateAppointmentDto
    {
        public string Name { get; set; }
        public string Dr { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
