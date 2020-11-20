using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.Helper;
using WMSAPI.Model;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YHCKController : ControllerBase
    {
        private IWMSS _Wmss;
        public YHCKController(IWMSS wmss)
        {
            _Wmss = wmss;
        }
        //出库明细显示
        [HttpGet]
        [Route("/api/Clibraryshow")]
        public async Task<IActionResult> Clibraryshow(int page,int limit, string outc="",string wtype="",string wname="",string gong="")
        {
            var Category = await _Wmss.Clibraryshow();
            if (!string.IsNullOrEmpty(outc))
            {
                Category = Category.Where(m => m.WName==outc).ToList();
            }
            if (!string.IsNullOrEmpty(wtype))
            {
                Category = Category.Where(m => m.PCategory.Contains(wtype)).ToList();
            }
            if (!string.IsNullOrEmpty(wname))
            {
                Category = Category.Where(m => m.PName.Contains(wname)).ToList();
            }
            if (!string.IsNullOrEmpty(gong))
            {
                Category = Category.Where(m => m.SName==gong).ToList();
            }
            
            var liat = Category.Skip((page - 1) * limit).Take(limit).ToList();
            var Count = Category.Count;
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count + 1, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);
        }

        //采购退货任务
        [HttpGet]
        [Route("/api/CGreturnedshow")]
        public async Task<IActionResult> CGreturnedshow(int page, int limit,int BHnumber = 0)
        {
            var Category = await _Wmss.CGreturnedshow();
            if (BHnumber!=0)
            {
                Category = Category.Where(m=>m.Tasknumber==BHnumber).ToList();
            }            
            var liat = Category.Skip((page - 1) * limit).Take(limit).ToList();
            var Count = Category.Count;
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count + 1, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);
        }

        //采购退货任务详情
        [HttpGet]
        [Route("/api/particularsshow")]
        public async Task<IActionResult> particularsshow(string wtype = "", string wname = "")
        {
            var Category = await _Wmss.particularsshow();
            if (!string.IsNullOrEmpty(wtype))
            {
                Category = Category.Where(m => m.PCategory.Contains(wtype)).ToList();
            }
            if (!string.IsNullOrEmpty(wname))
            {
                Category = Category.Where(m => m.PName.Contains(wname)).ToList();
            }
            return Ok(Category);
        }

        //库区绑定下拉
        [HttpGet]
        [Route("/api/KQbang")]
        public async Task<IActionResult> KQbang()
        {
            var Category = await _Wmss.KQbang();
            string json = JsonConvert.SerializeObject(Category);
            return Ok(json);
        }
    }
}
