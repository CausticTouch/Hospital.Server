using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Usrs
{
    public class CreateUsrDto
    {
        public CreateUsrDto()
        { }
        public CreateUsrDto(string email,
                            string password,
                            string gender,
                            string firstName,
                            string lastName,
                            DateTime dateBirth,
                            string phone,
                            string nationality,
                            string ocupation,
                            string address,
                            string postCode,
                            float? height,
                            int? weight)
        {
            Email = email;
            Password = password;
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            DateBirth = dateBirth;
            Phone = phone;
            Nationality = nationality;
            Ocupation = ocupation;
            Address = address;
            PostCode = postCode;
            Height = height;
            Weight = weight;
        }

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
