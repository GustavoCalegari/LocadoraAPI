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
        public bool habilitado { get; set; }

        public Cliente(string nome, string email, string telefone, string sexo, string logradouro, int numeroResidencia, bool habilitado)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.sexo = sexo;
            this.logradouro = logradouro;
            this.numeroResidencia = numeroResidencia;
            this.habilitado = habilitado;
        }
    }
}