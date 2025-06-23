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
        telefone = "11980000001",
        logradouro = "Av. Paulista",
        numero = "1000",
        cep = "01310-100",
        bairro = "Bela Vista",
        cidade = "São Paulo",
        uf = "SP",
        senha = "mari@2025"
    },
    new Usuario
    {
        id = 2,
        nome = "Carlos Oliveira",
        email = "carlos.oliveira@fotografia.com",
        telefone = "21980000002",
        logradouro = "Rua das Laranjeiras",
        numero = "200",
        cep = "22240-003",
        bairro = "Laranjeiras",
        cidade = "Rio de Janeiro",
        uf = "RJ",
        senha = "foto@2025"
    },
    new Usuario
    {
        id = 3,
        nome = "Ana Beatriz Lima",
        email = "ana.lima@buffetfest.com",
        telefone = "31980000003",
        logradouro = "Av. Afonso Pena",
        numero = "1500",
        cep = "30130-003",
        bairro = "Centro",
        cidade = "Belo Horizonte",
        uf = "MG",
        senha = "buffet@2025"
    },
    new Usuario
    {
        id = 4,
        nome = "Lucas Martins",
        email = "lucas.martins@iluminacaoeventos.com",
        telefone = "51980000004",
        logradouro = "Rua da Aurora",
        numero = "250",
        cep = "90040-530",
        bairro = "Centro Histórico",
        cidade = "Porto Alegre",
        uf = "RS",
        senha = "luz@2025"
    },
    new Usuario
    {
        id = 5,
        nome = "Juliana Castro",
        email = "juliana.castro@decorvip.com",
        telefone = "11980000005",
        logradouro = "Av. Rebouças",
        numero = "450",
        cep = "05402-000",
        bairro = "Pinheiros",
        cidade = "São Paulo",
        uf = "SP",
        senha = "decor@2025"
    },
    new Usuario
    {
        id = 6,
        nome = "Fernando Lima",
        email = "fernando.lima@eventosmusicais.com",
        telefone = "41980000006",
        logradouro = "Rua XV de Novembro",
        numero = "789",
        cep = "80020-310",
        bairro = "Centro",
        cidade = "Curitiba",
        uf = "PR",
        senha = "musica@2025"
    },
    new Usuario
    {
        id = 7,
        nome = "Patrícia Nunes",
        email = "patricia.nunes@eventoplanner.com",
        telefone = "62980000007",
        logradouro = "Av. T-63",
        numero = "321",
        cep = "74230-032",
        bairro = "Setor Bueno",
        cidade = "Goiânia",
        uf = "GO",
        senha = "planner@2025"
    },
    new Usuario
    {
        id = 8,
        nome = "Bruno Ferreira",
        email = "bruno.ferreira@eventsound.com",
        telefone = "71980000008",
        logradouro = "Av. ACM",
        numero = "999",
        cep = "41830-000",
        bairro = "Itaigara",
        cidade = "Salvador",
        uf = "BA",
        senha = "sound@2025"
    },
    new Usuario
    {
        id = 9,
        nome = "Renata Dias",
        email = "renata.dias@cerimonialeventos.com",
        telefone = "85980000009",
        logradouro = "Rua Barão de Studart",
        numero = "567",
        cep = "60120-000",
        bairro = "Aldeota",
        cidade = "Fortaleza",
        uf = "CE",
        senha = "cerimonial@2025"
    },
    new Usuario
    {
        id = 10,
        nome = "Thiago Rocha",
        email = "thiago.rocha@techfest.com",
        telefone = "21980000010",
        logradouro = "Av. das Américas",
        numero = "3500",
        cep = "22640-102",
        bairro = "Barra da Tijuca",
        cidade = "Rio de Janeiro",
        uf = "RJ",
        senha = "tech@2025"
    }
            );
        }
    }
}