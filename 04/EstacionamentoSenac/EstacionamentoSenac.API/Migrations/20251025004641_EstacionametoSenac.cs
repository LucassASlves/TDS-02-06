using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstacionamentoSenac.API.Migrations
{
    /// <inheritdoc />
    public partial class EstacionametoSenac : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "Veiculos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos");

            migrationBuilder.RenameTable(
                name: "Veiculos",
                newName: "Veiculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Id");
        }
    }
}
