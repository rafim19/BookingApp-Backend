using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model
{
    [DatabaseName("DB")]
    [Table("trCustomerPayment")]
    public class TrCustomerPayment : BaseModel
    {
        [Key]
        [Column("PaymentID")]
        public string PaymentID { get; set; }
        [ForeignKey("BookingID")]
        [Column("BookingID")]
        public string BookingID { get; set; }
        [ForeignKey("CustomerID")]
        [Column("CustomerID")]
        public string CustomerID { get; set; }
        [Column("PaymentMethod")]
        public string PaymentMethod { get; set; }
        [Column("PaymentAmount")]
        public string PaymentAmount { get; set; }
        [DataType(DataType.Date)]
        [Column("PaymentDate")]
        public DateTime PaymentDate { get; set; }
        [Column("RoomBook")]
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
