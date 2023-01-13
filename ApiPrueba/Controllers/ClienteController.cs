using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpGet]
        public IEnumerable<Models.Cliente> Get()
        {
            using (var db = new Models.PruebaApiContext())
            {
                IEnumerable<Models.Cliente> clientes = db.Clientes.ToList();

                return clientes;
            }

        }
    }
}
