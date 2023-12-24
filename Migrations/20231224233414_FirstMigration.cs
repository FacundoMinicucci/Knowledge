using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace knowledge.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Names = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surnames = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CUIT = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CellphoneNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(320)", maxLength: 320, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Traces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Aplicacion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Componente = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Exception = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Mensaje = table.Column<string>(type: "longtext", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traces", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TraceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<string>(type: "longtext", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TraceId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraceDetails_Traces_TraceId",
                        column: x => x.TraceId,
                        principalTable: "Traces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Active", "Address", "BirthDate", "CUIT", "CellphoneNumber", "Email", "Names", "Surnames" },
                values: new object[,]
                {
                    { 1, true, "Address1", new DateOnly(1993, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test1@gmail.com", "Name1", "Surname1" },
                    { 2, true, "Address2", new DateOnly(1992, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test2@gmail.com", "Name2", "Surname2" },
                    { 3, true, "Address3", new DateOnly(1991, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test3@gmail.com", "Name3", "Surname3" },
                    { 4, true, "Address4", new DateOnly(1990, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test4@gmail.com", "Name4", "Surname4" },
                    { 5, true, "Address5", new DateOnly(1989, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test5@gmail.com", "Name5", "Surname5" },
                    { 6, true, "Address6", new DateOnly(1988, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test6@gmail.com", "Name6", "Surname6" },
                    { 7, true, "Address7", new DateOnly(1987, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test7@gmail.com", "Name7", "Surname7" },
                    { 8, true, "Address8", new DateOnly(1986, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test8@gmail.com", "Name8", "Surname8" },
                    { 9, true, "Address9", new DateOnly(1985, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test9@gmail.com", "Name9", "Surname9" },
                    { 10, true, "Address10", new DateOnly(1984, 11, 25), "20-37978110-2", "1160166647", "facundonicolasminicucci+test10@gmail.com", "Name10", "Surname10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TraceDetails_TraceId",
                table: "TraceDetails",
                column: "TraceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TraceDetails");

            migrationBuilder.DropTable(
                name: "Traces");
        }
    }
}
