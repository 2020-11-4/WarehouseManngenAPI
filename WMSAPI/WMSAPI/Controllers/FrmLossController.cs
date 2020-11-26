using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.Helper;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrmLossController : ControllerBase
    {
        private IWMSS _Wmss;
        public FrmLossController(IWMSS wmss)
        {
            _Wmss = wmss;
        }
        [HttpGet]
        [Route("/api/FMShow")]
        public async Task<IActionResult> FMShow(int page, int limit)
        {
            var AOGShow = await _Wmss.FMShow();
            var Count = AOGShow.Count;
            var liat = AOGShow.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);

        }
    }
}
