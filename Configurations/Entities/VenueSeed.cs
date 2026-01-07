using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        //public void Configure(EntityTypeBuilder<Venue> builder)
        //{
        //    builder.HasData(
        //        //new Venue
        //        //{
        //        //    VenueID = 1,
        //        //    Address = "",
        //        //    PostalCode = "",
        //        //    UnitNumber = "",
        //        //}
        //    );
        //}
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            throw new NotImplementedException();
        }
    }
}
