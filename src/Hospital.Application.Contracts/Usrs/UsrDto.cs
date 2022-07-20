using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hospital.Usrs
{
    public class UsrDto : FullAuditedEntityDto<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }
#nullable enable
        public string? Nationality { get; set; }
        public string? Ocupation { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public float? Height { get; set; }
        public int? Weight { get; set; }
    }
}
