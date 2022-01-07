using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Partea2.Migrations
{
    public partial class DataProgramarii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataProgramarii",
                table: "Doctor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataProgramarii",
                table: "Doctor");
        }
    }
}
