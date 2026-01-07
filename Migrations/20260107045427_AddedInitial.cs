using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class AddedInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37814f50-0c80-443a-9ef1-e74fbbd6a9fa", "AQAAAAIAAYagAAAAENWgyRcmyyYRLQ6Qms18r+fs5UvS62PcaTS6SqllVbdvUF7VEy/BgdNgNvtdDXv5MQ==", "6701f9f1-d300-45e7-bb3a-f20bef8caae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034d444e-4696-42b6-9d5f-dd161a4ded81", "AQAAAAIAAYagAAAAEIpL/0PA8Vh4CHgtbyg4vvJxUqSIYFFUQCL/5V3n3mIknAwWajoUh61OBeAmQabHCg==", "37bb9440-86d2-45b5-b02d-868a08543529" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
