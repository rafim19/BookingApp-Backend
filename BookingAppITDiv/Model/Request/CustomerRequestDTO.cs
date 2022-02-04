using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Models.Request
{
    public class CustomerRequestDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public char Stsrc { get; set; }
        public string UserIn { get; set; }
        public string? UserUp { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateUp { get; set; }
    }
}
