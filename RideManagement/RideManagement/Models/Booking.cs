using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideManagement.Models
{
    public class Booking
    {
        [ForeignKey("RideSchedules")]
        public int BookingID { get; set; }
        public int BookedOn { get; set; }
        public int RiderUserId { get; set;}
        public int NoOfSeats { get; set;}
        public int TotalAmount { get; set; }
        public string PaymentMode { get; set; }
        public int RideSchedulesID { get; set; }

    }
}
