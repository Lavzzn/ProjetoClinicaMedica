using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoClinicaMedica.API.Migrations
{
    /// <inheritdoc />
    public partial class AltereiConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diagnosticos",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnosticos",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Consultas");
        }
    }
}
