using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Partea2.Migrations
{
    public partial class ProgramareServiciu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Programare_ProgramareID",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "DataProgramarii",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramareID",
                table: "Doctor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Serviciu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviciu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProgramareServiciu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramareId = table.Column<int>(type: "int", nullable: false),
                    ServiciuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramareServiciu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramareServiciu_Programare_ProgramareId",
                        column: x => x.ProgramareId,
                        principalTable: "Programare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramareServiciu_Serviciu_ServiciuId",
                        column: x => x.ServiciuId,
                        principalTable: "Serviciu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramareServiciu_ProgramareId",
                table: "ProgramareServiciu",
                column: "ProgramareId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramareServiciu_ServiciuId",
                table: "ProgramareServiciu",
                column: "ServiciuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Programare_ProgramareID",
                table: "Doctor",
                column: "ProgramareID",
                principalTable: "Programare",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Programare_ProgramareID",
                table: "Doctor");

            migrationBuilder.DropTable(
                name: "ProgramareServiciu");

            migrationBuilder.DropTable(
                name: "Serviciu");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramareID",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataProgramarii",
                table: "Doctor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Programare_ProgramareID",
                table: "Doctor",
                column: "ProgramareID",
                principalTable: "Programare",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
