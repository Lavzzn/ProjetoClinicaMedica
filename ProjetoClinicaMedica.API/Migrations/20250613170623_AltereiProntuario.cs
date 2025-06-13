using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoClinicaMedica.API.Migrations
{
    /// <inheritdoc />
    public partial class AltereiProntuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Pacientes_Pacienteid",
                table: "Prontuarios");

            migrationBuilder.DropColumn(
                name: "PacienteNome",
                table: "Prontuarios");

            migrationBuilder.RenameColumn(
                name: "Pacienteid",
                table: "Prontuarios",
                newName: "PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuarios_Pacienteid",
                table: "Prontuarios",
                newName: "IX_Prontuarios_PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Pacientes_PacienteId",
                table: "Prontuarios",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Pacientes_PacienteId",
                table: "Prontuarios");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "Prontuarios",
                newName: "Pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuarios_PacienteId",
                table: "Prontuarios",
                newName: "IX_Prontuarios_Pacienteid");

            migrationBuilder.AddColumn<string>(
                name: "PacienteNome",
                table: "Prontuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Pacientes_Pacienteid",
                table: "Prontuarios",
                column: "Pacienteid",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
