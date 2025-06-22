using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MBProject.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                column: "dtCriacao",
                value: new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 2,
                column: "dtCriacao",
                value: new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 3,
                column: "dtCriacao",
                value: new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 4,
                column: "dtCriacao",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 5,
                column: "dtCriacao",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 6,
                column: "dtCriacao",
                value: new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 7,
                column: "dtCriacao",
                value: new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 8,
                column: "dtCriacao",
                value: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 9,
                column: "dtCriacao",
                value: new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 10,
                column: "dtCriacao",
                value: new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                column: "dtCriacao",
                value: new DateTime(2025, 3, 15, 9, 13, 51, 506, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 2,
                column: "dtCriacao",
                value: new DateTime(2025, 3, 25, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 3,
                column: "dtCriacao",
                value: new DateTime(2025, 3, 30, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 4,
                column: "dtCriacao",
                value: new DateTime(2025, 4, 14, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 5,
                column: "dtCriacao",
                value: new DateTime(2025, 4, 19, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 6,
                column: "dtCriacao",
                value: new DateTime(2025, 5, 4, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 7,
                column: "dtCriacao",
                value: new DateTime(2025, 5, 9, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 8,
                column: "dtCriacao",
                value: new DateTime(2025, 5, 14, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 9,
                column: "dtCriacao",
                value: new DateTime(2025, 5, 24, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 10,
                column: "dtCriacao",
                value: new DateTime(2025, 6, 3, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1779));
        }
    }
}
