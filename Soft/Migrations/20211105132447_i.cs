using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Abc.Soft.Migrations {
    public partial class i : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Equipments",
                newName: "Definition");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Therapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Physiotherapists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Physiotherapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Nutritionists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Nutritionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Coaches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Athletes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Administrators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Physiotherapists");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Administrators");

            migrationBuilder.RenameColumn(
                name: "Definition",
                table: "Equipments",
                newName: "Description");
        }
    }
}
