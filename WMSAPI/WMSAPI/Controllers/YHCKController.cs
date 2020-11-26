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
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count , data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);
        }

        //采购退货任务详情
        [HttpGet]
        [Route("/api/particularsshow")]
        public async Task<IActionResult> particularsshow(int index = 0, int size = 8, string wtype = "", string wname = "")
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
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

        //产品出库任务详情
        [HttpGet]
        [Route("/api/CPoutshow")]
        public async Task<IActionResult> CPoutshow(int index = 0, int size = 8, string wtype = "", string wname = "")
        {
            var Category = await _Wmss.CPoutshow();
            if (!string.IsNullOrEmpty(wtype))
            {
                Category = Category.Where(m => m.PCategory.Contains(wtype)).ToList();
            }
            if (!string.IsNullOrEmpty(wname))
            {
                Category = Category.Where(m => m.PName.Contains(wname)).ToList();
            }
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

        //出库记录
        [Route("/api/CKrecord")]
        public async Task<IActionResult> CKrecord(int index = 0, int size = 8)
        {
            var Category = await _Wmss.CKrecord();
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
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

        //产品显示
        [HttpGet]
        [Route("/api/CPshow")]
        public async Task<IActionResult> CPshow(int index = 0, int size = 8)
        {
            var Category = await _Wmss.CPshow();
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

        //添加出库任务
        [HttpGet]
        [Route("/api/outtask")]
        public async Task<IActionResult> outtask()
        {
            var Category = await _Wmss.outtask();
            return Ok(Category);
        }

        //添加盘点任务
        [HttpPost]
        [Route("/api/PDAdd")]
        public int PDAdd([FromBody] pandian Warehouse)
        {
            int i = _Wmss.PDAdd(Warehouse);
            return i;
        }

        //盘点任务管理未盘点
        [HttpGet]
        [Route("/api/panshow")]
        public async Task<IActionResult> panshow(int index = 0, int size = 8)
        {
            var Category = await _Wmss.panshow();
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

        //盘点任务管理已盘点
        [HttpGet]
        [Route("/api/panyshow")]
        public async Task<IActionResult> panyshow(int index = 0, int size = 8,string pdanhao="",string pname="",string pren="",string time="",string pcang="",string pqu="")
        {
            var Category = await _Wmss.panyshow();
            if (!string.IsNullOrEmpty(pdanhao))
            {
                Category = Category.Where(m => m.pdanhao.Contains(pdanhao)).ToList();
            }
            if (!string.IsNullOrEmpty(pname))
            {
                Category = Category.Where(m => m.pname.Contains(pname)).ToList();
            }
            if (!string.IsNullOrEmpty(pren))
            {
                Category = Category.Where(m => m.pren.Contains(pren)).ToList();
            }
            if (!string.IsNullOrEmpty(time))
            {
                Category = Category.Where(m => m.ptime.Contains(time)).ToList();
            }
            if (!string.IsNullOrEmpty(pcang))
            {
                Category = Category.Where(m => m.pwarehouse.Contains(pcang)).ToList();
            }
            if (!string.IsNullOrEmpty(pqu))
            {
                Category = Category.Where(m => m.parea.Contains(pqu)).ToList();
            }
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

        //未盘点详情
        [HttpGet]
        [Route("/api/xiangqing")]
        public async Task<IActionResult> xiangqing(int id, int index = 0, int size = 8)
        {
            var Category = await _Wmss.xiangqing(id);
            int count = Category.Count;
            Category = Category.Skip((index - 1) * size).Take(size).ToList();
            return Ok(Category);
        }

    }
}