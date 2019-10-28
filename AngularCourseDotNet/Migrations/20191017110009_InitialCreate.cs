using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularCourseDotNet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Values",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Values");

            migrationBuilder.DropColumn(
                name: "password",
                table: "User");
        }
    }
}
