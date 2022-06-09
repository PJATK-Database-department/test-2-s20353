using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TEST_2_NET_5_proper.Migrations
{
    public partial class Foundation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Test_2");

            migrationBuilder.CreateTable(
                name: "CityDict",
                schema: "Test_2",
                columns: table => new
                {
                    IdCityDict = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityDict", x => x.IdCityDict);
                });

            migrationBuilder.CreateTable(
                name: "Passenger",
                schema: "Test_2",
                columns: table => new
                {
                    IdPassenger = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PassportNum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.IdPassenger);
                });

            migrationBuilder.CreateTable(
                name: "Plane",
                schema: "Test_2",
                columns: table => new
                {
                    IdPlane = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaxSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plane", x => x.IdPlane);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "Test_2",
                columns: table => new
                {
                    IdFlight = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlane = table.Column<int>(type: "int", nullable: false),
                    IdCityDict = table.Column<int>(type: "int", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.IdFlight);
                    table.ForeignKey(
                        name: "FK_Flight_CityDict_IdCityDict",
                        column: x => x.IdCityDict,
                        principalSchema: "Test_2",
                        principalTable: "CityDict",
                        principalColumn: "IdCityDict",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flight_Plane_IdPlane",
                        column: x => x.IdPlane,
                        principalSchema: "Test_2",
                        principalTable: "Plane",
                        principalColumn: "IdPlane",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Firefighter_Action",
                schema: "Test_2",
                columns: table => new
                {
                    IdFlight = table.Column<int>(type: "int", nullable: false),
                    IdPassenger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firefighter_Action", x => x.IdFlight);
                    table.ForeignKey(
                        name: "FK_Firefighter_Action_Flight_IdFlight",
                        column: x => x.IdFlight,
                        principalSchema: "Test_2",
                        principalTable: "Flight",
                        principalColumn: "IdFlight",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Firefighter_Action_Passenger_IdPassenger",
                        column: x => x.IdPassenger,
                        principalSchema: "Test_2",
                        principalTable: "Passenger",
                        principalColumn: "IdPassenger",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "CityDict",
                columns: new[] { "IdCityDict", "City" },
                values: new object[,]
                {
                    { 1, "Warszawa" },
                    { 2, "Tokyo" }
                });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Passenger",
                columns: new[] { "IdPassenger", "FirstName", "LastName", "PassportNum" },
                values: new object[,]
                {
                    { 1, "John", "Doe", "ABC123" },
                    { 2, "Jane", "Smith", "DEF456" }
                });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Plane",
                columns: new[] { "IdPlane", "MaxSeats", "Name" },
                values: new object[,]
                {
                    { 1, 50, "FirstPlane" },
                    { 2, 100, "SecondPlane" }
                });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Flight",
                columns: new[] { "IdFlight", "Comments", "FlightDate", "IdCityDict", "IdPlane" },
                values: new object[] { 1, null, new DateTime(2022, 6, 9, 15, 5, 0, 379, DateTimeKind.Local).AddTicks(6889), 1, 1 });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Flight",
                columns: new[] { "IdFlight", "Comments", "FlightDate", "IdCityDict", "IdPlane" },
                values: new object[] { 2, "generic comment", new DateTime(2022, 6, 9, 15, 5, 0, 381, DateTimeKind.Local).AddTicks(2177), 2, 2 });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Firefighter_Action",
                columns: new[] { "IdFlight", "IdPassenger" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                schema: "Test_2",
                table: "Firefighter_Action",
                columns: new[] { "IdFlight", "IdPassenger" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Firefighter_Action_IdPassenger",
                schema: "Test_2",
                table: "Firefighter_Action",
                column: "IdPassenger");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_IdCityDict",
                schema: "Test_2",
                table: "Flight",
                column: "IdCityDict");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_IdPlane",
                schema: "Test_2",
                table: "Flight",
                column: "IdPlane");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firefighter_Action",
                schema: "Test_2");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "Test_2");

            migrationBuilder.DropTable(
                name: "Passenger",
                schema: "Test_2");

            migrationBuilder.DropTable(
                name: "CityDict",
                schema: "Test_2");

            migrationBuilder.DropTable(
                name: "Plane",
                schema: "Test_2");
        }
    }
}
