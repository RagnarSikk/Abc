using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Abc.Soft.Migrations {
    public partial class newBaseData : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Therapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Therapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Physiotherapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Physiotherapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Nutritionists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Nutritionists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Equipments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Equipments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Coaches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Coaches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Athletes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Athletes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Administrators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Administrators",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Administrators");
        }
    }
}
