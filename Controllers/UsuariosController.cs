using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API_MBProject.Models;
using API_MBProject.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_MBProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>()
        {
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
                dtCriacao = DateTime.Now.AddDays(-90),
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
                dtCriacao = DateTime.Now.AddDays(-80),
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
                dtCriacao = DateTime.Now.AddDays(-75),
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
                dtCriacao = DateTime.Now.AddDays(-60),
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
                dtCriacao = DateTime.Now.AddDays(-55),
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
                dtCriacao = DateTime.Now.AddDays(-40),
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
                dtCriacao = DateTime.Now.AddDays(-35),
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
                dtCriacao = DateTime.Now.AddDays(-30),
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
                dtCriacao = DateTime.Now.AddDays(-20),
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
                dtCriacao = DateTime.Now.AddDays(-10),
                links = "https://vibeeventos.com",
                tipoUsuario = TipoUsuario.Contratante
            }
        };


        //MÉTODOS GET
        [HttpGet("GetUsuarios")]
        public IActionResult GetUsuarios()
        {
            List<Usuario> u = usuarios;
            return Ok(u);
        }

        [HttpGet("GetUserById/{id}")]
        public IActionResult GetUserById(int id)
        {
            Usuario u = usuarios.FirstOrDefault(u => u.id == id);
            return Ok(u);
        }

        [HttpGet("GetByNomeAprox/{nome}")]
        public IActionResult GetUsersByNomeAproximado(string nome)
        {
            List<Usuario> u = usuarios.FindAll(u => u.nome.Contains(nome));
            return Ok(u);
        }

        //MÉTODOS POST
        [HttpPost("PostUsuarios")]
        public IActionResult PostUsuarios(Usuario u)
        {
            if (usuarios.Find(user => user.id == u.id) == null)
            {
                usuarios.Add(u);
                return Ok(u);
            }
            else
            {
                return BadRequest("Não podes adicionar um usuário já existente");
            }
        }


        //MÉTODOS PUSH

        //MÉTODOS DELETE


        // private readonly ILogger<UsuariosController> _logger;

        // public UsuariosController(ILogger<UsuariosController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}