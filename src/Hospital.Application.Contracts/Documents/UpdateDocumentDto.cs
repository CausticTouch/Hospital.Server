using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Documents
{
    public class UpdateDocumentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PatientInfo { get; set; }
        public string Desc { get; set; }
    }
}
