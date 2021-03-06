﻿using LocadoraAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace FilmeAPI.Controllers
{
    public class FilmeController : ApiController
    {

        // GET: api/Filme
        [HttpGet]
        public List<Filme> ListarFilmes()
        {
            Filme filme = new Filme();

            return filme.retornarFilmes();

        }

        // GET: api/Filme/5
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

        // PUT: api/Filme/
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
