using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abc.Soft.Migrations
{
    public partial class EquipmentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountAvailable",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "AmountInUsing",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Equipments",
                newName: "PersonRoleTypeId");

            migrationBuilder.RenameColumn(
                name: "Definition",
                table: "Equipments",
                newName: "EquipmentTypeId");

            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.RenameColumn(
                name: "PersonRoleTypeId",
                table: "Equipments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EquipmentTypeId",
                table: "Equipments",
                newName: "Definition");

            migrationBuilder.AddColumn<int>(
                name: "AmountAvailable",
                table: "Equipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountInUsing",
                table: "Equipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
