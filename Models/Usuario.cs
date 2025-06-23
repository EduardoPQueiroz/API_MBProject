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
        public string telefone { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string senha { get; set; }
    
    }
}