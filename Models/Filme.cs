using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Filme
    {
        public string nome { get; set; }
        public string genero { get; set; }
        public bool disponivel { get; set; }
        public bool habilitado { get; set; }

        public Filme(string nome, string genero, bool disponivel, bool habilitado)
        {
            this.nome = nome;
            this.genero = genero;
            this.disponivel = disponivel;
            this.habilitado = habilitado;
        }
    }
}