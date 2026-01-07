using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthIsWealth.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Facility_FacilityId",
                table: "Timeslot");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Venue_VenueId",
                table: "Timeslot");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslot_Facility_FacilityId",
                table: "Timeslot",
                column: "FacilityId",
                principalTable: "Facility",
                principalColumn: "FacilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslot_Venue_VenueId",
                table: "Timeslot",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Facility_FacilityId",
                table: "Timeslot");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslot_Venue_VenueId",
                table: "Timeslot");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78ac4baa-22fe-47e9-beeb-de3ffa5d8195", "AQAAAAIAAYagAAAAEOQcbBTM/s/p9wNqjTQpCqvAAF7LaJK+ggZsGOzRBOBZE86DYiagvijZKPxGAxep4Q==", "784e96b4-a198-4822-810d-64ac60bd9c6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbbf6cfd-2861-45e8-a76a-eb543fabe175", "AQAAAAIAAYagAAAAEH+W4vgHMvnT2WP17k0wXFe5JoDHiqIxOQ9NsGrXEcTmadRVPep6w88ufJkB/7FArg==", "02118b41-6258-41af-bbb3-cf96ecd750b4" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 1,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "TimeslotId",
                keyValue: 2,
                columns: new[] { "FacilityId", "VenueId" },
                values: new object[] { null, null });

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
    }
}
