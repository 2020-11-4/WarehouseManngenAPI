using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.Model;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YHCKController : ControllerBase
    {
        //private IWMSS vehicle;
        //public YHCKController(IWMSS vehicleManagement)
        //{
        //    vehicle = vehicleManagement;
        //}
        private IWMSS _Wmss;
        public YHCKController(IWMSS wmss)
        {
            _Wmss = wmss;
        }
        //出库明细显示
        [HttpGet]
        public async Task<IActionResult> Clibraryshow()
        {

            return Ok(await _Wmss.Clibraryshow());
        }
    }
}
