using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MBProject.Models.Enums;

namespace API_MBProject.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string biografia { get; set; }
        public DateTime dtCriacao { get; set; }
        public string links { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
    }
}