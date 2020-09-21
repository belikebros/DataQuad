using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WCFService;

namespace DataQuadCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataQuadController : ControllerBase
    {
        private IDataQuadService _service;

        public DataQuadController(IDataQuadService service)
        {
            _service = service;
        }

        // GET: api/dataquad/GetAllRaces
        [HttpGet("GetAllRaces")]
        public IActionResult GetAllRaces()
        {
            var ret = _service.GetAllRaces();
            return Ok(ret);
        }

        // GET: api/dataquad/Sample
        [HttpGet("Sample")]
        public IActionResult Sample()
        {
            return Ok(_service.sample());
        }
    }
}