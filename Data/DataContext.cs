using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MBProject.Models;
using API_MBProject.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace API_MBProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Usuario> TB_USUARIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");

            modelBuilder.Entity<Usuario>().HasData(

                new Usuario
                {
                    id = 1,
                    nome = "Mariana Souza",
                    email = "mariana.souza@eventosvip.com",
                    senha = "mari@2025",
                    telefone = "11980000001",
                    endereco = "Av. Paulista, 1000 - São Paulo/SP",
                    fotoPerfil = new byte[0],
                    biografia = "Produtora de eventos corporativos e casamentos.",
                    dtCriacao = new DateTime(2024, 3, 1),
                    links = "https://instagram.com/mari_eventos",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 2,
                    nome = "Carlos Menezes",
                    email = "carlosm@agenciashow.com",
                    senha = "carl@321",
                    telefone = "11980000002",
                    endereco = "Rua das Rosas, 205 - Campinas/SP",
                    fotoPerfil = new byte[0],
                    biografia = "Agente de talentos e responsável por contratações em festivais.",
                    dtCriacao = new DateTime(2024, 3, 11),
                    links = "https://linkedin.com/in/carlosmenezes",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 3,
                    nome = "Fernanda Lima",
                    email = "fernanda.lima@festprime.com",
                    senha = "fernanda@fest",
                    telefone = "11980000003",
                    endereco = "Av. Atlântica, 750 - Rio de Janeiro/RJ",
                    fotoPerfil = new byte[0],
                    biografia = "Organizadora de festas privadas e aniversários de luxo.",
                    dtCriacao = new DateTime(2024, 3, 16),
                    links = "https://festprime.com/fernanda",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 4,
                    nome = "José Roberto",
                    email = "jose.roberto@prefeituraevento.gov",
                    senha = "evento123",
                    telefone = "11980000004",
                    endereco = "Praça Central, 1 - Belo Horizonte/MG",
                    fotoPerfil = new byte[0],
                    biografia = "Responsável por agendamentos musicais em eventos públicos.",
                    dtCriacao = new DateTime(2024, 3, 26),
                    links = "",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 5,
                    nome = "Luciana Torres",
                    email = "luciana.torres@noitesom.com",
                    senha = "lucitorres2025",
                    telefone = "11980000005",
                    endereco = "Rua Alegre, 99 - Porto Alegre/RS",
                    fotoPerfil = new byte[0],
                    biografia = "Contrata músicos para casas noturnas e bares temáticos.",
                    dtCriacao = new DateTime(2024, 3, 31),
                    links = "https://noitesom.com/luciana",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 6,
                    nome = "Henrique Alves",
                    email = "henrique.alves@casadossons.com",
                    senha = "henri2025",
                    telefone = "11980000006",
                    endereco = "Rua do Som, 456 - Salvador/BA",
                    fotoPerfil = new byte[0],
                    biografia = "Dono da Casa dos Sons, especialista em shows de médio porte.",
                    dtCriacao = new DateTime(2024, 4, 15),
                    links = "https://casadossons.com",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 7,
                    nome = "Patrícia Rocha",
                    email = "patricia@festou.com.br",
                    senha = "patfest2025",
                    telefone = "11980000007",
                    endereco = "Rua da Alegria, 78 - Recife/PE",
                    fotoPerfil = new byte[0],
                    biografia = "Planejadora de eventos infantis e familiares com atrações musicais.",
                    dtCriacao = new DateTime(2024, 4, 20),
                    links = "https://festou.com.br",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 8,
                    nome = "Rafael Dias",
                    email = "rafael.dias@produzshow.com",
                    senha = "dias@show",
                    telefone = "11980000008",
                    endereco = "Rua Independência, 505 - Curitiba/PR",
                    fotoPerfil = new byte[0],
                    biografia = "Produtor de festivais de rock e MPB.",
                    dtCriacao = new DateTime(2024, 4, 25),
                    links = "https://produzshow.com",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 9,
                    nome = "Isabela Martins",
                    email = "isabela.martins@musicsoul.com",
                    senha = "isa123",
                    telefone = "11980000009",
                    endereco = "Rua Harmonia, 300 - Florianópolis/SC",
                    fotoPerfil = new byte[0],
                    biografia = "Curadora de artistas independentes para eventos regionais.",
                    dtCriacao = new DateTime(2024, 5, 5),
                    links = "",
                    tipoUsuario = TipoUsuario.Contratante
                },
                new Usuario
                {
                    id = 10,
                    nome = "Thiago Nunes",
                    email = "thiago.nunes@vibeeventos.com",
                    senha = "nunes@2025",
                    telefone = "11980000010",
                    endereco = "Av. das Luzes, 1122 - Goiânia/GO",
                    fotoPerfil = new byte[0],
                    biografia = "Empresário do setor de entretenimento e shows.",
                    dtCriacao = new DateTime(2024, 5, 15),
                    links = "https://vibeeventos.com",
                    tipoUsuario = TipoUsuario.Contratante
                }
            );
        }
    }
}