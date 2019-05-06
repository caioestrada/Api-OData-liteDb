using System.Collections.Generic;
using System.Linq;
using C.Estudo.LiteDb.Domain.Entitites;
using C.Estudo.LiteDb.Infra.Data.Repositories;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace C.Estudo.LiteDb.ServiceApi.Controllers
{
    public class ClientesController : ODataController
    {
        private ClienteRepository _clienteRepository;

        public ClientesController()
        {
            _clienteRepository = new ClienteRepository();
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_clienteRepository.Listar());
        }
    }
}
