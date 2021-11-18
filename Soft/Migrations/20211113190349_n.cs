using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Abc.Soft.Migrations {
    public partial class n : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "AdministartorId",
                table: "Administrators");

            migrationBuilder.AddColumn<string>(
                name: "ServiceProviderId",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceProviderId",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceProviderId",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationOfTraining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableEquipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxNumberOfAthletes = table.Column<int>(type: "int", nullable: false),
                    MinNumberOfAthletes = table.Column<int>(type: "int", nullable: false),
                    NumberOfAthletes = table.Column<int>(type: "int", nullable: false),
                    NumberOfCoachesRequired = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropColumn(
                name: "ServiceProviderId",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "ServiceProviderId",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "ServiceProviderId",
                table: "Nutritionists");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdministartorId",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
