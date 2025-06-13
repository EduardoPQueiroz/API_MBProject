using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_MBProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fotoPerfil = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dtCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    links = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "id", "biografia", "dtCriacao", "email", "endereco", "fotoPerfil", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[,]
                {
                    { 1, "Produtora de eventos corporativos e casamentos.", new DateTime(2025, 3, 15, 9, 13, 51, 506, DateTimeKind.Local).AddTicks(9220), "mariana.souza@eventosvip.com", "Av. Paulista, 1000 - São Paulo/SP", new byte[0], "https://instagram.com/mari_eventos", "Mariana Souza", "mari@2025", "11980000001", 1 },
                    { 2, "Agente de talentos e responsável por contratações em festivais.", new DateTime(2025, 3, 25, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1387), "carlosm@agenciashow.com", "Rua das Rosas, 205 - Campinas/SP", new byte[0], "https://linkedin.com/in/carlosmenezes", "Carlos Menezes", "carl@321", "11980000002", 1 },
                    { 3, "Organizadora de festas privadas e aniversários de luxo.", new DateTime(2025, 3, 30, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1754), "fernanda.lima@festprime.com", "Av. Atlântica, 750 - Rio de Janeiro/RJ", new byte[0], "https://festprime.com/fernanda", "Fernanda Lima", "fernanda@fest", "11980000003", 1 },
                    { 4, "Responsável por agendamentos musicais em eventos públicos.", new DateTime(2025, 4, 14, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1759), "jose.roberto@prefeituraevento.gov", "Praça Central, 1 - Belo Horizonte/MG", new byte[0], "", "José Roberto", "evento123", "11980000004", 1 },
                    { 5, "Contrata músicos para casas noturnas e bares temáticos.", new DateTime(2025, 4, 19, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1763), "luciana.torres@noitesom.com", "Rua Alegre, 99 - Porto Alegre/RS", new byte[0], "https://noitesom.com/luciana", "Luciana Torres", "lucitorres2025", "11980000005", 1 },
                    { 6, "Dono da Casa dos Sons, especialista em shows de médio porte.", new DateTime(2025, 5, 4, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1766), "henrique.alves@casadossons.com", "Rua do Som, 456 - Salvador/BA", new byte[0], "https://casadossons.com", "Henrique Alves", "henri2025", "11980000006", 1 },
                    { 7, "Planejadora de eventos infantis e familiares com atrações musicais.", new DateTime(2025, 5, 9, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1769), "patricia@festou.com.br", "Rua da Alegria, 78 - Recife/PE", new byte[0], "https://festou.com.br", "Patrícia Rocha", "patfest2025", "11980000007", 1 },
                    { 8, "Produtor de festivais de rock e MPB.", new DateTime(2025, 5, 14, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1772), "rafael.dias@produzshow.com", "Rua Independência, 505 - Curitiba/PR", new byte[0], "https://produzshow.com", "Rafael Dias", "dias@show", "11980000008", 1 },
                    { 9, "Curadora de artistas independentes para eventos regionais.", new DateTime(2025, 5, 24, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1775), "isabela.martins@musicsoul.com", "Rua Harmonia, 300 - Florianópolis/SC", new byte[0], "", "Isabela Martins", "isa123", "11980000009", 1 },
                    { 10, "Empresário do setor de entretenimento e shows.", new DateTime(2025, 6, 3, 9, 13, 51, 511, DateTimeKind.Local).AddTicks(1779), "thiago.nunes@vibeeventos.com", "Av. das Luzes, 1122 - Goiânia/GO", new byte[0], "https://vibeeventos.com", "Thiago Nunes", "nunes@2025", "11980000010", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIOS");
        }
    }
}
