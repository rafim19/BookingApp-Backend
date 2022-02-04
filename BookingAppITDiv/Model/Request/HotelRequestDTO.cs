using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model.Request
{
    public class HotelRequestDTO
    {
        public string HotelID { get; set; }
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
        public char Stsrc { get; set; }
        public string UserIn { get; set; }
        public string UserUp { get; set; }
        public string DateIn { get; set; }
        public string DateUp { get; set; }
    }
}
