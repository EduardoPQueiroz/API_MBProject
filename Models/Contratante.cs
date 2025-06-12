using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MBProject.Models.Enums;

namespace API_MBProject.Models
{
    public class Contratante : Usuario
    {
        public string nomeEmpresa { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public TipoContratante tipoContratante { get; set; }
    }
}