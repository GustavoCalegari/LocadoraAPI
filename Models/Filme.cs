using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Filme
    {
        public int idFilme { get; set; }
        public string nome { get; set; }
        public string genero { get; set; }
        public bool disponivel { get; set; }
        public bool habilitado { get; set; }

        public Filme()
        {
        }

        public List<Filme> retornarFilmes()
        {
            List<Filme> filmes = new List<Filme>();

            Conexao cnn = new Conexao();
            SqlCommand cmm = new SqlCommand();

            return filmes;
        }
    }
}