using LocadoraAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace LocadoraAPI.Controllers
{
    public class LocadorController : ApiController
    {

        // GET: api/Locador
        public List<Locacoes> ListarLocacoes()
        {
            Locacoes locacao = new Locacoes();

            return locacao.retornarLocacoes();

        }

        // GET: api/Locador/5
        public List<Locacoes> ListarLocacao(int id)
        {
            Locacoes locacao = new Locacoes();

            return locacao.retornarLocacao(id);
        }

    }
}
