using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class AddFacilitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645d200a-0789-4093-87d9-b1a558fd9880", "AQAAAAIAAYagAAAAEP5kYcK04JAsw5lxc9ArrVq5RGsGhy91q828y0LNfeKrDc/H4hV0HO2rEdBTP+BtPw==", "7652c6d0-ad79-4285-834c-0ead4c631a22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d234172c-a769-42c6-9e0f-6b5f8e57cedc", "AQAAAAIAAYagAAAAEOdFzzPERIfahh9G7rnR6bKUPVnCOPP6qo39FO+VZw+myh09vyeuIzXNDoxp3QnxwA==", "f89c69ce-40f7-4a6c-8275-341538083b7c" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Address", "PostalCode", "UnitNumber" },
                values: new object[] { 1, "Sambawang", "123456", "01-1234" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "Location", "Name", "Price", "VenueId" },
                values: new object[] { 1, "Hall A", "Badminton Court", 0f, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facility",
                keyColumn: "FacilityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3060c1a3-a081-4c56-bb26-a5a2f63cb8ae", "AQAAAAIAAYagAAAAEIjuTTz7j24cnAl5pucgaYQUTL0ZbKND5uLkR+iYFcY+N6ZvV9Gmio7IRw1WqCSVVA==", "b9e702e9-b57d-466d-812a-bb3237563d1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac854d4-4819-4a84-b94c-0181a0492ce5", "AQAAAAIAAYagAAAAEAl7Qqx5IRjEjgTo0s/kYPuAXMLt+IPJ7aPvHNEKin0lR9bnYvkuz6qPk2LQC7d+aQ==", "0ec0b2fe-76f0-41d4-8738-a8669935cfb7" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { 0, 0 });
        }
    }
}
