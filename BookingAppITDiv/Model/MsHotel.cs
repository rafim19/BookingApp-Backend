using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model
{
    [DatabaseName("DB")]
    [Table("msHotel")]
    public class MsHotel : BaseModel
    {
        [Key]
        [Column("HotelID")]
        public string HotelID { get; set; }
        [Column("HotelName")]
        public string HotelName { get; set; }
        [Column("HotelDescription")]
        public string HotelDescription { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("Rating")]
        public string Rating { get; set; }
        [Column("Image")]
        public string Image { get; set; }
        [Column("Stsrc")]
        public char Stsrc { get; set; }
        [Column("UserIn")]
        public string UserIn { get; set; }
        [Column("UserUp")]
        public string UserUp { get; set; }
        [Column("DateIn")]
        public DateTime DateIn { get; set; }
        [Column("DateUp")]
        public DateTime DateUp { get; set; }
    }
}
