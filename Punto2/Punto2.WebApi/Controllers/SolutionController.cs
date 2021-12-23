using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Punto2.Core.Abstractions;
using Punto2.Core.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Punto2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionController : ControllerBase
    {
        private IAppLogic _appLogic;

        public SolutionController(IAppLogic appLogic)
        {
            _appLogic = appLogic;
        }

        [HttpPost]
        public IActionResult Solution([FromBody] Request request)
        {
            return Ok(_appLogic.Resolve(request).Result);
        }
    }
}
