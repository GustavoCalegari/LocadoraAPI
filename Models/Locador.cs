using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Locador
    {
        public string nome { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }

        public Locador(string nome, string logradouro, int numero)
        {
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
        }
    }
}