using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Finist_TestTask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "CardAccounts",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SecondName = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    CardAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    DemandAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpressAccountId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DemandAccounts",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpressAccounts",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpressAccounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "CardAccounts",
                columns: new[] { "Id", "AccountNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("17a390db-bcbb-40e1-a4d8-fca984296efd"), "42305840513000000112", new Guid("9e8aab80-4ab5-4177-99e8-0bdeed2885cd") },
                    { new Guid("762728d8-fbe2-4374-9968-8131aa57b8f2"), "93567840589112300112", new Guid("46a7b9cd-1de8-4777-aa4e-edff233d3550") }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Clients",
                columns: new[] { "Id", "CardAccountId", "DemandAccountId", "ExpressAccountId", "Name", "Patronymic", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { new Guid("46a7b9cd-1de8-4777-aa4e-edff233d3550"), new Guid("762728d8-fbe2-4374-9968-8131aa57b8f2"), new Guid("05f3c60f-f9fa-401e-ad0f-b2202a538371"), new Guid("3e13e435-573a-4513-96d8-0cb5e7f43750"), "Тест", "Тестович", "+79992223344", "Тестов" },
                    { new Guid("9e8aab80-4ab5-4177-99e8-0bdeed2885cd"), new Guid("17a390db-bcbb-40e1-a4d8-fca984296efd"), new Guid("f64cad21-cb98-4d23-bd43-ee483ac6ee9f"), new Guid("20229757-84fd-4c55-946e-c5c65ab7d093"), "Тест2", "Тестович2", "+79980007633", "Тестов2" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "DemandAccounts",
                columns: new[] { "Id", "AccountNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("05f3c60f-f9fa-401e-ad0f-b2202a538371"), "69756952598567995321", new Guid("46a7b9cd-1de8-4777-aa4e-edff233d3550") },
                    { new Guid("f64cad21-cb98-4d23-bd43-ee483ac6ee9f"), "71642567061085536844", new Guid("9e8aab80-4ab5-4177-99e8-0bdeed2885cd") }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "ExpressAccounts",
                columns: new[] { "Id", "AccountNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("20229757-84fd-4c55-946e-c5c65ab7d093"), "70152631400678905460", new Guid("9e8aab80-4ab5-4177-99e8-0bdeed2885cd") },
                    { new Guid("3e13e435-573a-4513-96d8-0cb5e7f43750"), "00365680679007776789", new Guid("46a7b9cd-1de8-4777-aa4e-edff233d3550") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardAccounts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Clients",
                schema: "public");

            migrationBuilder.DropTable(
                name: "DemandAccounts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ExpressAccounts",
                schema: "public");
        }
    }
}
