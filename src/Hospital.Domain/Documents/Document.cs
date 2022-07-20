using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hospital.Documents
{
    public class Document : FullAuditedAggregateRoot<Guid>
    {
        public Document(string firstName, string lastName, string email, string phoneNumber, string patientInfo, string desc)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PatientInfo = patientInfo;
            Desc = desc;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PatientInfo { get; set; }
        public string Desc { get; set; }

    }
}
