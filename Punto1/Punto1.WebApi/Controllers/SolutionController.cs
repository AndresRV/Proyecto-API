using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Punto1.Core.Abstractions;
using Punto1.Core.Requests;
using Punto1.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Punto1.WebApi.Controllers
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
            return Ok(_appLogic.Resolve(request));
        }
    }
}
