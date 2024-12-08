using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace airport.Data.Migrations
{
    /// <inheritdoc />
    public partial class join : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "describe",
                table: "statuses",
                newName: "Describe");

            migrationBuilder.RenameColumn(
                name: "statusId",
                table: "statuses",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "takingOffTime",
                table: "flights",
                newName: "TakingOffTime");

            migrationBuilder.RenameColumn(
                name: "source",
                table: "flights",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "landTime",
                table: "flights",
                newName: "LandTime");

            migrationBuilder.RenameColumn(
                name: "destination",
                table: "flights",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "airplanId",
                table: "flights",
                newName: "AirplanId");

            migrationBuilder.RenameColumn(
                name: "flightId",
                table: "flights",
                newName: "FlightId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "flights",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "companyName",
                table: "companies",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "companies",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "airplaneType",
                table: "airplanes",
                newName: "AirplaneType");

            migrationBuilder.RenameColumn(
                name: "airplanId",
                table: "airplanes",
                newName: "AirplanId");

            migrationBuilder.AddColumn<int>(
                name: "AirplaneAirplanId",
                table: "flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_flights_AirplaneAirplanId",
                table: "flights",
                column: "AirplaneAirplanId");

            migrationBuilder.CreateIndex(
                name: "IX_flights_StatusId",
                table: "flights",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_flights_airplanes_AirplaneAirplanId",
                table: "flights",
                column: "AirplaneAirplanId",
                principalTable: "airplanes",
                principalColumn: "AirplanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_statuses_StatusId",
                table: "flights",
                column: "StatusId",
                principalTable: "statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flights_airplanes_AirplaneAirplanId",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_statuses_StatusId",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "IX_flights_AirplaneAirplanId",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "IX_flights_StatusId",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "AirplaneAirplanId",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "Describe",
                table: "statuses",
                newName: "describe");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "statuses",
                newName: "statusId");

            migrationBuilder.RenameColumn(
                name: "TakingOffTime",
                table: "flights",
                newName: "takingOffTime");

            migrationBuilder.RenameColumn(
                name: "Source",
                table: "flights",
                newName: "source");

            migrationBuilder.RenameColumn(
                name: "LandTime",
                table: "flights",
                newName: "landTime");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "flights",
                newName: "destination");

            migrationBuilder.RenameColumn(
                name: "AirplanId",
                table: "flights",
                newName: "airplanId");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "flights",
                newName: "flightId");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "flights",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "companies",
                newName: "companyName");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "companies",
                newName: "companyId");

            migrationBuilder.RenameColumn(
                name: "AirplaneType",
                table: "airplanes",
                newName: "airplaneType");

            migrationBuilder.RenameColumn(
                name: "AirplanId",
                table: "airplanes",
                newName: "airplanId");
        }
    }
}
