using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0acaa29-2e9a-42bb-bac6-4fc8b1c941f0", "AQAAAAIAAYagAAAAEJCWEmRq5a47/aNoEH+ZsHyFRbWhyKJTn/byC+Pi0jfHDv5y55vT4YYD2aGLNlwHcw==", "02b3e498-29ed-42d3-86c6-c785fd060d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "298790ae-27ed-4d73-baa0-957c2a3df397", "AQAAAAIAAYagAAAAEOKno4P9CIDPsv74woneXawbRNDsPAxXRSsQBvG14H1+BimDXjuF3OiBzKn7u2A0YQ==", "6a649916-fd34-4241-89e1-c99850371db6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
