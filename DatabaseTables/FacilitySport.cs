using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthIsWealth.DatabaseTables
{
    public class FacilitySport
    {
        public int FacilitySportID { get; set; }
        public int SportID { get; set; }
        public int FacilityID { get; set; }
        public int VenueID { get; set; }

        //Navigation Properties
        public Sport Sport { get; set; }
        public Facility Facility { get; set; }
}
}
