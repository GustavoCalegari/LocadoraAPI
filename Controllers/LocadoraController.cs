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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
