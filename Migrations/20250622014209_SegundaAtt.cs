using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MBProject.Migrations
{
    /// <inheritdoc />
    public partial class SegundaAtt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fotoPerfil",
                table: "TB_USUARIOS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "fotoPerfil",
                table: "TB_USUARIOS",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 2,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 3,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 4,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 5,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 6,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 7,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 8,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 9,
                column: "fotoPerfil",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 10,
                column: "fotoPerfil",
                value: new byte[0]);
        }
    }
}
