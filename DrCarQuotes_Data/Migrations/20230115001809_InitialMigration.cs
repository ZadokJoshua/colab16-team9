using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrCarQuotesData.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mechanics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MechanicId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    RepairServiceId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_RepairServices_RepairServiceId",
                        column: x => x.RepairServiceId,
                        principalTable: "RepairServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "BMW", "I4", 2012 },
                    { 2, "Audi", "A6", 2005 },
                    { 3, "Fiat", "500x", 2020 },
                    { 4, "Toyota", "Hilux", 2015 },
                    { 5, "Acura", "Enclave", 2020 },
                    { 6, "GMC", "Canyon", 2020 },
                    { 7, "Ford", "Edge", 2016 },
                    { 8, "Ford", "Escape", 2021 },
                    { 9, "Audi", "A4", 2020 },
                    { 10, "Chevrolet", "Cruze", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Mechanics",
                columns: new[] { "Id", "Address", "Name", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { 1, "127-4 Willets Point Blvd, Corona, NY 11368, United States", "Sam Auto Shop", "+1234588823", "20374" },
                    { 2, "724 State Rd., Philadelphia, PA 19136, United States", "Repair Guys", "+1384588223", "19136" },
                    { 3, "520 Florida Ave NE, Washington, DC 20002, United States", "Automotive Brothers", "+1344588823", "20002" },
                    { 4, "261 Shirlington Rd, Arlington, VA 22206, United States", "Hill Auto Repair", "+1684580823", "22206" },
                    { 5, "143 Build America Dr, Woodbridge, VA 22191, United States", "A & Y Auto Masters", "+1784585823", "22191" },
                    { 6, "3600 Rhawn St, Philadelphia, PA 19136, United States", "Car Doctors Auto Shop", "+1984548823", "19136" },
                    { 7, "567 Elm St, Corona, NY 11368, United States", "Auto Express", "+1984548823", "20374" },
                    { 8, "890 Main St, Corona, NY 11368, United States", "Car Care Pro", "+1784585823", "20374" },
                    { 9, "123 Park Ave, Corona, NY 11368, United States", "Car Repair Guys", "+1684580823", "20374" },
                    { 10, "456 Pine St, Philadelphia, PA 19136, United States", "Master Auto Shop", "+1344588823", "19136" },
                    { 11, "789 Oak St, Philadelphia, PA 19136, United States", "Pro Auto Repair", "+1384588223", "19136" },
                    { 12, "321 Maple St, Philadelphia, PA 19136, United States", "Auto Repair Pro", "+1234588823", "19136" },
                    { 13, "912 Elm St, Corona, NY 11368, United States", "Auto Repair Zone", "+1984548823", "20374" },
                    { 14, "890 Main St, Corona, NY 11368, United States", "Auto Care Guys", "+1784585823", "20374" },
                    { 15, "123 Park Ave, Corona, NY 11368, United States", "Auto Repair Pro", "+1684580823", "20374" },
                    { 16, "456 Pine St, Philadelphia, PA 19136, United States", "Car Repair Pro", "+1344588823", "19136" },
                    { 17, "789 Oak St, Philadelphia, PA 19136, United States", "Auto Repair Guys", "+1384588223", "19136" },
                    { 18, "321 Maple St, Philadelphia, PA 19136, United States", "Auto Repair Express", "+1234588823", "19136" },
                    { 19, "567 Elm St, Corona, NY 11368, United States", "Auto Repair Shop", "+1984548823", "20374" },
                    { 20, "890 Main St, Corona, NY 11368, United States", "Auto Repair Pro", "+1784585823", "20374" }
                });

            migrationBuilder.InsertData(
                table: "RepairServices",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Oil Change" },
                    { 2, "Brake Pads" },
                    { 3, "Windshield Wiper" },
                    { 4, "Air Filter" },
                    { 5, "Spark Plug" },
                    { 6, "Tire Change" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CarId", "MechanicId", "Price", "RepairServiceId" },
                values: new object[,]
                {
                    { 1, 1, 1, 50m, 1 },
                    { 2, 2, 2, 75m, 2 },
                    { 3, 3, 3, 100m, 3 },
                    { 4, 4, 4, 125m, 4 },
                    { 5, 5, 5, 150m, 5 },
                    { 6, 6, 6, 200m, 6 },
                    { 7, 7, 7, 225m, 1 },
                    { 8, 8, 8, 250m, 2 },
                    { 9, 9, 9, 275m, 3 },
                    { 10, 10, 10, 300m, 4 },
                    { 11, 1, 11, 325m, 5 },
                    { 12, 2, 12, 350m, 6 },
                    { 13, 3, 13, 375m, 1 },
                    { 14, 4, 14, 400m, 2 },
                    { 15, 5, 15, 425m, 3 },
                    { 16, 6, 16, 450m, 4 },
                    { 17, 7, 17, 475m, 5 },
                    { 18, 8, 18, 500m, 6 },
                    { 19, 9, 19, 525m, 1 },
                    { 20, 10, 20, 550m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CarId",
                table: "Quotes",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_MechanicId",
                table: "Quotes",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_RepairServiceId",
                table: "Quotes",
                column: "RepairServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Mechanics");

            migrationBuilder.DropTable(
                name: "RepairServices");
        }
    }
}
