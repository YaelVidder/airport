using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace airport.Data.Migrations
{
    /// <inheritdoc />
    public partial class _290125 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Source",
                table: "flights",
                newName: "SourceLocationId");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "flights",
                newName: "SourceLoationLocationId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationLoationLocationId",
                table: "flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationLocationId",
                table: "flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_flights_CompanyId",
                table: "flights",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_flights_DestinationLoationLocationId",
                table: "flights",
                column: "DestinationLoationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_flights_SourceLoationLocationId",
                table: "flights",
                column: "SourceLoationLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_flights_companies_CompanyId",
                table: "flights",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_locations_DestinationLoationLocationId",
                table: "flights",
                column: "DestinationLoationLocationId",
                principalTable: "locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_locations_SourceLoationLocationId",
                table: "flights",
                column: "SourceLoationLocationId",
                principalTable: "locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flights_companies_CompanyId",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_locations_DestinationLoationLocationId",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_locations_SourceLoationLocationId",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "IX_flights_CompanyId",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "IX_flights_DestinationLoationLocationId",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "IX_flights_SourceLoationLocationId",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "DestinationLoationLocationId",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "DestinationLocationId",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "SourceLocationId",
                table: "flights",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "SourceLoationLocationId",
                table: "flights",
                newName: "Destination");
        }
    }
}
