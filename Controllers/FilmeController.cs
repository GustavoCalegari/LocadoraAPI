using LocadoraAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FilmeAPI.Controllers
{
    public class FilmeController : ApiController
    {

        // GET: filmes/Filme/ListarFilmes
        [HttpGet]
        public List<Filme> ListarFilmes()
        {
            Filme filme = new Filme();

            return filme.retornarFilmes();

        }

        // GET: filmes/Filme/5
        public List<Filme> ListarFilme(int id)
        {
            Filme filme = new Filme();

            return filme.retornarFilme(id);
        }

        // POST: api/Filme
        public string Post([FromBody] Filme novoFilme)
        {
            Filme filme = new Filme();

            return filme.cadastrarFilme(novoFilme.nome, novoFilme.genero, novoFilme.disponivel);
        }

        // PUT: api/Filme/5
        public string Put([FromBody] Filme editar)
        {
            Filme filme = new Filme();

            return filme.atualizarFilme(editar.idFilme, editar.nome, editar.genero);
        }

        // DELETE: api/Filme/5
        public string Delete(int id)
        {
            Filme filme = new Filme();

            return filme.excluirFilme(id);
        }
    }
}
