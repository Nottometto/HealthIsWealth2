namespace HealthIsWealth.Domain
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? ImageSource { get; set; }
        public int VenueId { get; set; }
        public float Price { get; set; }

        //Navigation Properties

        public Venue Venue { get; set; }
        public ICollection<Timeslot> Timeslots { get; set; }
        public ICollection<FacilitySport> FacilitySports { get; set; }
    }
}
