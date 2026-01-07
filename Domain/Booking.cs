using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthIsWealth.Domain
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int TimeslotID { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        //Navigation Properties

        public User User { get; set; }
        public Timeslot Timeslot { get; set; }
        public Review? Review { get; set; }
    }
}
