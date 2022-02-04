using Binus.WS.Pattern.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingAppITDiv.Model.Request
{
    public class CustomerPaymentRequestDTO
    {
        public string PaymentID { get; set; }
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public char Stsrc { get; set; }
        public string UserIn { get; set; }
        public string UserUp { get; set; }
        public string DateIn { get; set; }
        public string DateUp { get; set; }
    }
}
