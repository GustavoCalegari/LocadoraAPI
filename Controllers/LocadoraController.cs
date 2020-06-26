using LocadoraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocadoraAPI.Controllers
{
    public class LocadoraController : ApiController
    {

        // GET: api/Locadora
        [HttpGet]
        public List<Filme> ListarFilmes()
        {
            Filme filme = new Filme();

            return filme.retornarFilmes();

        }

        // GET: api/Locadora/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Locadora
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Locadora/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Locadora/5
        public void Delete(int id)
        {
        }
    }
}
