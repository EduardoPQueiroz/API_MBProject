using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MBProject.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dtCriacao",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "tipoUsuario",
                table: "TB_USUARIOS");

            migrationBuilder.RenameColumn(
                name: "links",
                table: "TB_USUARIOS",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "TB_USUARIOS",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "biografia",
                table: "TB_USUARIOS",
                newName: "logradouro");

            migrationBuilder.AddColumn<string>(
                name: "bairro",
                table: "TB_USUARIOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cep",
                table: "TB_USUARIOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cidadde",
                table: "TB_USUARIOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "bairro", "cep", "cidadde", "logradouro", "numero", "uf" },
                values: new object[] { "Bela Vista", "01310-100", "São Paulo", "Av. Paulista", "1000", "SP" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Laranjeiras", "22240-003", "Rio de Janeiro", "carlos.oliveira@fotografia.com", "Rua das Laranjeiras", "Carlos Oliveira", "200", "foto@2025", "21980000002", "RJ" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Centro", "30130-003", "Belo Horizonte", "ana.lima@buffetfest.com", "Av. Afonso Pena", "Ana Beatriz Lima", "1500", "buffet@2025", "31980000003", "MG" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Centro Histórico", "90040-530", "Porto Alegre", "lucas.martins@iluminacaoeventos.com", "Rua da Aurora", "Lucas Martins", "250", "luz@2025", "51980000004", "RS" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "uf" },
                values: new object[] { "Pinheiros", "05402-000", "São Paulo", "juliana.castro@decorvip.com", "Av. Rebouças", "Juliana Castro", "450", "decor@2025", "SP" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Centro", "80020-310", "Curitiba", "fernando.lima@eventosmusicais.com", "Rua XV de Novembro", "Fernando Lima", "789", "musica@2025", "41980000006", "PR" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Setor Bueno", "74230-032", "Goiânia", "patricia.nunes@eventoplanner.com", "Av. T-63", "Patrícia Nunes", "321", "planner@2025", "62980000007", "GO" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Itaigara", "41830-000", "Salvador", "bruno.ferreira@eventsound.com", "Av. ACM", "Bruno Ferreira", "999", "sound@2025", "71980000008", "BA" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Aldeota", "60120-000", "Fortaleza", "renata.dias@cerimonialeventos.com", "Rua Barão de Studart", "Renata Dias", "567", "cerimonial@2025", "85980000009", "CE" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "bairro", "cep", "cidadde", "email", "logradouro", "nome", "numero", "senha", "telefone", "uf" },
                values: new object[] { "Barra da Tijuca", "22640-102", "Rio de Janeiro", "thiago.rocha@techfest.com", "Av. das Américas", "Thiago Rocha", "3500", "tech@2025", "21980000010", "RJ" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bairro",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "cidadde",
                table: "TB_USUARIOS");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "TB_USUARIOS",
                newName: "links");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "TB_USUARIOS",
                newName: "endereco");

            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "TB_USUARIOS",
                newName: "biografia");

            migrationBuilder.AddColumn<DateTime>(
                name: "dtCriacao",
                table: "TB_USUARIOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "tipoUsuario",
                table: "TB_USUARIOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "biografia", "dtCriacao", "endereco", "links", "tipoUsuario" },
                values: new object[] { "Produtora de eventos corporativos e casamentos.", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Av. Paulista, 1000 - São Paulo/SP", "https://instagram.com/mari_eventos", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Agente de talentos e responsável por contratações em festivais.", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlosm@agenciashow.com", "Rua das Rosas, 205 - Campinas/SP", "https://linkedin.com/in/carlosmenezes", "Carlos Menezes", "carl@321", "11980000002", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Organizadora de festas privadas e aniversários de luxo.", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fernanda.lima@festprime.com", "Av. Atlântica, 750 - Rio de Janeiro/RJ", "https://festprime.com/fernanda", "Fernanda Lima", "fernanda@fest", "11980000003", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Responsável por agendamentos musicais em eventos públicos.", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "jose.roberto@prefeituraevento.gov", "Praça Central, 1 - Belo Horizonte/MG", "", "José Roberto", "evento123", "11980000004", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "tipoUsuario" },
                values: new object[] { "Contrata músicos para casas noturnas e bares temáticos.", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "luciana.torres@noitesom.com", "Rua Alegre, 99 - Porto Alegre/RS", "https://noitesom.com/luciana", "Luciana Torres", "lucitorres2025", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Dono da Casa dos Sons, especialista em shows de médio porte.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "henrique.alves@casadossons.com", "Rua do Som, 456 - Salvador/BA", "https://casadossons.com", "Henrique Alves", "henri2025", "11980000006", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Planejadora de eventos infantis e familiares com atrações musicais.", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "patricia@festou.com.br", "Rua da Alegria, 78 - Recife/PE", "https://festou.com.br", "Patrícia Rocha", "patfest2025", "11980000007", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Produtor de festivais de rock e MPB.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafael.dias@produzshow.com", "Rua Independência, 505 - Curitiba/PR", "https://produzshow.com", "Rafael Dias", "dias@show", "11980000008", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Curadora de artistas independentes para eventos regionais.", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabela.martins@musicsoul.com", "Rua Harmonia, 300 - Florianópolis/SC", "", "Isabela Martins", "isa123", "11980000009", 1 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "biografia", "dtCriacao", "email", "endereco", "links", "nome", "senha", "telefone", "tipoUsuario" },
                values: new object[] { "Empresário do setor de entretenimento e shows.", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "thiago.nunes@vibeeventos.com", "Av. das Luzes, 1122 - Goiânia/GO", "https://vibeeventos.com", "Thiago Nunes", "nunes@2025", "11980000010", 1 });
        }
    }
}
