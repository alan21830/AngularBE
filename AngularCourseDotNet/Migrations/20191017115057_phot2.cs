using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularCourseDotNet.Migrations
{
    public partial class phot2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Values",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Values");
        }
    }
}
