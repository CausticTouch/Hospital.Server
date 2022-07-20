using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Documents
{
    public class CreateDocumentDto
    {
        public CreateDocumentDto()
        { }

        public CreateDocumentDto(string firstName, string lastName, string email, string phoneNumber, string patientInfo, string desc)
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
