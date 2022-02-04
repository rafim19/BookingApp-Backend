using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model.Request
{
    public class CustomerBookingRequestDTO
    {
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public string RoomID { get; set; }
        public DateTime BookingDate { get; set; }
        public int TotalPrice { get; set; }
        public string BookingStatus { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string TotalNights { get; set; }
        public char Stsrc { get; set; }
        public string UserIn { get; set; }
        public string UserUp { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateUp { get; set; }
    }
}
