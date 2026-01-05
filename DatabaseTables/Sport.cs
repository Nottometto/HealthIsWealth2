using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthIsWealth.DatabaseTables
{
    public class Sport
    {
        public int SportID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Navigation Property
        public ICollection<FacilitySport> FacilitySports { get; set; }
    }
}
