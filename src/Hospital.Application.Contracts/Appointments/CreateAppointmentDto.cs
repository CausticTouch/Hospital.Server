using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Appointments
{
    public class CreateAppointmentDto
    {
        public CreateAppointmentDto()
        { }
        public CreateAppointmentDto(string name, string dr, DateTime date,DateTime time, string description)
        {
            Name = name;
            Dr = dr;
            Date = date;
            Time = time;
            Description = description;
        }
        public string Name { get; set; }
        public string Dr { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
    }
}
