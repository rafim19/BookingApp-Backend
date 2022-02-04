using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model
{
    [DatabaseName("DB")]
    [Table("trCustomerBooking")]
    public class TrCustomerBooking : BaseModel
    {
        [Key]
        [Column("BookingID")]
        public string BookingID { get; set; }
        [ForeignKey("CustomerID")]
        [Column("CustomerID")]
        public string CustomerID { get; set; }
        [ForeignKey("RoomID")]
        [Column("RoomID")]
        public string RoomID { get; set; }
        [DataType(DataType.Date)]
        [Column("BookingDate")]
        public DateTime BookingDate { get; set; }
        [Column("TotalPrice")]
        public int TotalPrice { get; set; }
        [Column("BookingStatus")]
        public string BookingStatus { get; set; }
        [Column("CheckInDate")]
        public DateTime CheckInDate { get; set; }
        [Column("CheckOutDate")]
        public DateTime CheckOutDate { get; set; }
        [Column("TotalNights")]
        public string TotalNights { get; set; }
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
