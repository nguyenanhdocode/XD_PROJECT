using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XD.DATA.Migrations
{
    public partial class myMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(255)", nullable: false),
                    APK = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("2d0b41e8-290d-4ba9-85b8-283857e4cd4d")),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 2, 18, 22, 46, 43, 795, DateTimeKind.Local).AddTicks(8089)),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExField10 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
