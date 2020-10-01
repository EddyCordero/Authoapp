using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Authoapp.API.Migrations
{
    public partial class Initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DateFrom = table.Column<DateTimeOffset>(nullable: false),
                    DateTo = table.Column<DateTimeOffset>(nullable: false),
                    PermissionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Notes", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(3370), null, "Vacaciones", null, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Notes", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(5000), null, "Licencia", null, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Notes", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(5030), null, "Enfermedad", null, new DateTime(2020, 10, 1, 1, 41, 27, 496, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "DateFrom", "DateTo", "DeletedAt", "FirstName", "LastName", "PermissionTypeId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 10, 1, 1, 41, 27, 498, DateTimeKind.Utc).AddTicks(7260), new DateTimeOffset(new DateTime(2020, 9, 30, 21, 41, 27, 498, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)), null, "Juan", "Perez", 1, new DateTime(2020, 10, 1, 1, 41, 27, 498, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "DateFrom", "DateTo", "DeletedAt", "FirstName", "LastName", "PermissionTypeId", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 10, 1, 1, 41, 27, 519, DateTimeKind.Utc).AddTicks(7000), new DateTimeOffset(new DateTime(2020, 9, 30, 21, 41, 27, 519, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)), null, "Maria", "Perez", 2, new DateTime(2020, 10, 1, 1, 41, 27, 519, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PermissionTypes");
        }
    }
}
