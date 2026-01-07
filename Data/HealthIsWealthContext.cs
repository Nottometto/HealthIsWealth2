using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using HealthIsWealth.Configurations.Entities;

namespace HealthIsWealth.Data
{
    {        
        {

        public DbSet<HealthIsWealth.DatabaseTables.User> User { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Timeslot> Timeslot { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Sport> Sport { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Review> Review { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.FacilitySport> FacilitySport { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Booking> Booking { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Venue> Venue { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Facility> Facility { get; set; } = default!;
    }
}
