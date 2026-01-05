using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class facilityForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Timeslot_FacilityID",
                table: "Timeslot",
                column: "FacilityID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookingID",
                table: "Review",
                column: "BookingID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_FacilityID",
                table: "FacilitySport",
                column: "FacilityID");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_SportID",
                table: "FacilitySport",
                column: "SportID");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_VenueID",
                table: "Facility",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TimeslotID",
                table: "Booking",
                column: "TimeslotID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserID",
                table: "Booking",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Timeslot_TimeslotID",
                table: "Booking",
                column: "TimeslotID",
                principalTable: "Timeslot",
                principalColumn: "TimeslotID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_User_UserID",
                table: "Booking",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facility_Venue_VenueID",
                table: "Facility",
                column: "VenueID",
                principalTable: "Venue",
                principalColumn: "VenueID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacilitySport_Facility_FacilityID",
                table: "FacilitySport",
                column: "FacilityID",
                principalTable: "Facility",
                principalColumn: "FacilityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacilitySport_Sport_SportID",
                table: "FacilitySport",
                column: "SportID",
                principalTable: "Sport",
                principalColumn: "SportID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Booking_BookingID",
                table: "Review",
                column: "BookingID",
                principalTable: "Booking",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslot_Facility_FacilityID",
                table: "Timeslot",
                column: "FacilityID",
                principalTable: "Facility",
                principalColumn: "FacilityID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Timeslot_TimeslotID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_User_UserID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Facility_Venue_VenueID",
                table: "Facility");

            migrationBuilder.DropForeignKey(
                name: "FK_FacilitySport_Facility_FacilityID",
                table: "FacilitySport");

            migrationBuilder.DropForeignKey(
                name: "FK_FacilitySport_Sport_SportID",
                table: "FacilitySport");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Booking_BookingID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Facility_FacilityID",
                table: "Timeslot");

            migrationBuilder.DropIndex(
                name: "IX_Timeslot_FacilityID",
                table: "Timeslot");

            migrationBuilder.DropIndex(
                name: "IX_Review_BookingID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_FacilitySport_FacilityID",
                table: "FacilitySport");

            migrationBuilder.DropIndex(
                name: "IX_FacilitySport_SportID",
                table: "FacilitySport");

            migrationBuilder.DropIndex(
                name: "IX_Facility_VenueID",
                table: "Facility");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TimeslotID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserID",
                table: "Booking");
        }
    }
}
