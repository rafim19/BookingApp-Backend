using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model
{
    [DatabaseName("DB")]
    [Table("msRoom")]
    public class MsRoom : BaseModel
    {
        [Key]
        [Column("RoomID")]
        public string RoomID { get; set; }
        [ForeignKey("HotelID")]
        [Column("HotelID")]
        public string HotelID { get; set; }
        [Column("RoomDescription")]
        public string RoomDescription { get; set; }
        [Column("Price")]
        public string Price { get; set; }
        [Column("RoomAvailable")]
        public string RoomAvailable { get; set; }
        [Column("RoomType")]
        public string RoomType { get; set; }
        [Column("RoomBook")]
        public string RoomBook { get; set; }
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
