using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Abc.Soft.Migrations {
    public partial class services : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceProviderRoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Equipments");
        }
    }
}
