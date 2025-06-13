using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoClinicaMedica.API.Migrations
{
    /// <inheritdoc />
    public partial class AddColunaDiagnostico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Medico",
                table: "Prontuarios",
                newName: "PacienteNome");

            migrationBuilder.RenameColumn(
                name: "Diagnósticos",
                table: "Prontuarios",
                newName: "Diagnosticos");

            migrationBuilder.AddColumn<Guid>(
                name: "Pacienteid",
                table: "Prontuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Prontuarios_Pacienteid",
                table: "Prontuarios",
                column: "Pacienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Pacientes_Pacienteid",
                table: "Prontuarios",
                column: "Pacienteid",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Pacientes_Pacienteid",
                table: "Prontuarios");

            migrationBuilder.DropIndex(
                name: "IX_Prontuarios_Pacienteid",
                table: "Prontuarios");

            migrationBuilder.DropColumn(
                name: "Pacienteid",
                table: "Prontuarios");

            migrationBuilder.RenameColumn(
                name: "PacienteNome",
                table: "Prontuarios",
                newName: "Medico");

            migrationBuilder.RenameColumn(
                name: "Diagnosticos",
                table: "Prontuarios",
                newName: "Diagnósticos");
        }
    }
}
