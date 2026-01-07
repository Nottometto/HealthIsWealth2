using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeslotSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VenueId",
                table: "Timeslot",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FacilityId",
                table: "Timeslot",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Review",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "78ac4baa-22fe-47e9-beeb-de3ffa5d8195", "test1@gmail.com", "TEST1@GMAIL.COM", "TEST1@GMAIL.COM", "AQAAAAIAAYagAAAAEOQcbBTM/s/p9wNqjTQpCqvAAF7LaJK+ggZsGOzRBOBZE86DYiagvijZKPxGAxep4Q==", "784e96b4-a198-4822-810d-64ac60bd9c6f", "test1@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d3d2829-89fa-4095-b0f9-0ef8e802fd69", 0, "dbbf6cfd-2861-45e8-a76a-eb543fabe175", "test2@gmail.com", true, "test", "2", false, null, "TEST2@GMAIL.COM", "TEST2@GMAIL.COM", "AQAAAAIAAYagAAAAEH+W4vgHMvnT2WP17k0wXFe5JoDHiqIxOQ9NsGrXEcTmadRVPep6w88ufJkB/7FArg==", null, false, "02118b41-6258-41af-bbb3-cf96ecd750b4", false, "test2@gmail.com" });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "TimeslotId", "EndDT", "FacilityId", "StartDT", "VenueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Timeslot_FacilityId",
                table: "Timeslot",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Timeslot_VenueId",
                table: "Timeslot",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookingId",
                table: "Review",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_FacilityId",
                table: "FacilitySport",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_SportId",
                table: "FacilitySport",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitySport_VenueId",
                table: "FacilitySport",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_VenueId",
                table: "Facility",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TimeslotId",
                table: "Booking",
                column: "TimeslotId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Timeslot_TimeslotId",
                table: "Booking",
                column: "TimeslotId",
                principalTable: "Timeslot",
                principalColumn: "TimeslotId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facility_Venue_VenueId",
                table: "Facility",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacilitySport_Facility_FacilityId",
                table: "FacilitySport",
                column: "FacilityId",
                principalTable: "Facility",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacilitySport_Sport_SportId",
                table: "FacilitySport",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacilitySport_Venue_VenueId",
                table: "FacilitySport",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Timeslot_BookingId",
                table: "Review",
                column: "BookingId",
                principalTable: "Timeslot",
                principalColumn: "TimeslotId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslot_Facility_FacilityId",
                table: "Timeslot",
                column: "FacilityId",
                principalTable: "Facility",
                principalColumn: "FacilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslot_Venue_VenueId",
                table: "Timeslot",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Timeslot_TimeslotId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Facility_Venue_VenueId",
                table: "Facility");

            migrationBuilder.DropForeignKey(
                name: "FK_FacilitySport_Facility_FacilityId",
                table: "FacilitySport");

            migrationBuilder.DropForeignKey(
                name: "FK_FacilitySport_Sport_SportId",
                table: "FacilitySport");

            migrationBuilder.DropForeignKey(
                name: "FK_FacilitySport_Venue_VenueId",
                table: "FacilitySport");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Timeslot_BookingId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Facility_FacilityId",
                table: "Timeslot");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Venue_VenueId",
                table: "Timeslot");

            migrationBuilder.DropIndex(
                name: "IX_Timeslot_FacilityId",
                table: "Timeslot");

            migrationBuilder.DropIndex(
                name: "IX_Timeslot_VenueId",
                table: "Timeslot");

            migrationBuilder.DropIndex(
                name: "IX_Review_BookingId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_UserId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_FacilitySport_FacilityId",
                table: "FacilitySport");

            migrationBuilder.DropIndex(
                name: "IX_FacilitySport_SportId",
                table: "FacilitySport");

            migrationBuilder.DropIndex(
                name: "IX_FacilitySport_VenueId",
                table: "FacilitySport");

            migrationBuilder.DropIndex(
                name: "IX_Facility_VenueId",
                table: "Facility");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TimeslotId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserId",
                table: "Booking");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69");

            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "VenueId",
                table: "Timeslot",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacilityId",
                table: "Timeslot",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e13910ff-6e77-4c81-bfc3-3281b29904b9", "test1@localhost.com", "TEST1@LOCALHOST.COM", "TEST1@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA61NjRWNoQh79wmQ92xLf7WS4AObuW0Wu6L//GX5VLBRDPXvWcvIGItF0K3N/Zaug==", "6bd92e08-c2c2-4878-949c-cd42726eda71", "test1@localhost.com" });
        }
    }
}
