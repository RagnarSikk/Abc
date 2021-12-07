using Microsoft.EntityFrameworkCore.Migrations;

namespace Abc.Soft.Migrations
{
    public partial class bodymetrictype1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "BodyMetrics");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "BodyMetrics",
                newName: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "BodyMetrics",
                newName: "Weight");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "BodyMetrics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
