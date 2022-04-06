using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlonassSoftTest.Migrations
{
    public partial class UserStatsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserStats",
                columns: new[] { "Id", "EmploymentDate", "Name" },
                values: new object[] { new Guid("539d5c23-aec2-4a22-a251-8af5a64cd69c"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xарламов Д.Д." });

            migrationBuilder.InsertData(
                table: "UserStats",
                columns: new[] { "Id", "EmploymentDate", "Name" },
                values: new object[] { new Guid("0986a4c1-48f3-4093-be14-72636de5036a"), new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сергеев С.Т." });

            migrationBuilder.InsertData(
                table: "UserStats",
                columns: new[] { "Id", "EmploymentDate", "Name" },
                values: new object[] { new Guid("8a43109b-ee6d-4914-b773-c6b5f910734c"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Смирнов А.В." });

            migrationBuilder.InsertData(
                table: "UserStats",
                columns: new[] { "Id", "EmploymentDate", "Name" },
                values: new object[] { new Guid("e4ae22fe-6791-4c3d-9378-d0c4d38b4062"), new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Куприенко Л.В." });

            migrationBuilder.InsertData(
                table: "UserStats",
                columns: new[] { "Id", "EmploymentDate", "Name" },
                values: new object[] { new Guid("7446b452-e059-4a09-a25e-dc9fa21a70b2"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Волкова А.В." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStats");
        }
    }
}
