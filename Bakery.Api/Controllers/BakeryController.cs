using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bakery.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {
        private readonly ILogger<BakeryController> _logger;

        public BakeryController(ILogger<BakeryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok("Project Bakery.");
        }
    }
}
