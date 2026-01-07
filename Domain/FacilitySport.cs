namespace HealthIsWealth.Domain
{
    public class FacilitySport
    {
        public int FacilitySportId { get; set; }
        public int SportID { get; set; }
        public int FacilityId { get; set; }
        public int VenueID { get; set; }

        //Navigation Properties
        public Sport Sport { get; set; }
        public Facility Facility { get; set; }
    }
}
