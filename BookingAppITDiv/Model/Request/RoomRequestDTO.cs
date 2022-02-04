using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model.Request
{
    public class RoomRequestDTO
    {
        public string RoomID { get; set; }
        public string HotelID { get; set; }
        public string RoomDescription { get; set; }
        public string Price { get; set; }
        public string RoomAvailable { get; set; }
        public string RoomType { get; set; }
        public string RoomBook { get; set; }
        public string Image { get; set; }
        public char Stsrc { get; set; }
        public string UserIn { get; set; }
        public string UserUp { get; set; }
        public string DateIn { get; set; }
        public string DateUp { get; set; }
    }
}
