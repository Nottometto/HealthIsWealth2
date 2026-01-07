using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class AddedTimeslotSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a18078c-065f-42c2-a1d0-4b95373e1bdb", "AQAAAAIAAYagAAAAEOCpb0ma6+tVX6lpyltzP7XOGve2ZnMrtH/4CUWITBt5I210XUfyLg0ijuCw6FJTNQ==", "9026a6ee-074e-4490-acfc-51c6dd1c9c26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece587dc-5207-4325-8ff9-7500ee3c88a3", "AQAAAAIAAYagAAAAEEZQUm0ddq+/QKVbiGn2tObWgn/4ngoPwatOsjjYCeuIfrxK7KT6Kz2gsxeMWDJz2g==", "1a532e0b-2d4a-489a-a865-dac75ea6059c" });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "TimeslotId", "EndDT", "FacilityId", "StartDT", "VenueId" },
                values: new object[] { 3, new DateTime(2024, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 3);

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
        }
    }
}
