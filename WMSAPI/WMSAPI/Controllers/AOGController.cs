using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMSAPI.Dal;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AOGController : ControllerBase
    {
        private IWMSS _Wmss;
        public AOGController(IWMSS wmss)
        {
            _Wmss = wmss;
        }

        [HttpGet]
        [Route("/api/AOGShowAsync")]
        public async Task<IActionResult> AOGShowAsync()
        {

            return Ok(await _Wmss.AOGShowAsync());
        }
    }
}
