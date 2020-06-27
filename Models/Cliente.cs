using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }
        public string logradouro { get; set; }
        public int numeroResidencia { get; set; }
        public string cpf { get; set; }

    }
}