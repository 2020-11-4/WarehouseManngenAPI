using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.help;

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

        //到货显示
        [HttpGet]
        [Route("/api/AOGShowAsync")]
        public async Task<IActionResult> AOGShowAsync(int page, int limit,string CDan,string CPin,string CGong,string CRen)
        {
            var AOGShow = await _Wmss.AOGShowAsync();

            if (!string.IsNullOrEmpty(CDan))
            {
                AOGShow = AOGShow.Where(st => st.Ordernumber.Contains(CDan)).ToList();
            }
            if (!string.IsNullOrEmpty(CPin))
            {
                int Pin = Convert.ToInt32(CPin);
                AOGShow = AOGShow.Where(st => st.Pid== Pin).ToList();
            }
            if (!string.IsNullOrEmpty(CGong))
            {
                AOGShow = AOGShow.Where(st => st.SName.Contains(CGong)).ToList();
            }
            if (!string.IsNullOrEmpty(CRen))
            {
                AOGShow = AOGShow.Where(st => st.Agent.Contains(CRen)).ToList();
            }

            var Count = AOGShow.Count();
            var liat = AOGShow.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count + 1, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);
        }

        //品类绑定
        [HttpGet]
        [Route("/api/CategoryAsync")]
        public async Task<IActionResult> CategoryAsync()
        {
            var Category = await _Wmss.CategoryAsync();
            string json = JsonConvert.SerializeObject(Category);
            return Ok(json);
        }
    }
}
