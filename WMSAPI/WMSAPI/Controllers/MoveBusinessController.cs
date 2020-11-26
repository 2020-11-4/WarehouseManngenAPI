using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.Helper;
using WMSAPI.Model;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveBusinessController : ControllerBase
    {
        public IWMSS GetWMSS;
        public MoveBusinessController(IWMSS WMS)
        {
            GetWMSS = WMS;
        }
        //调拨单列表
        [HttpGet]
        [Route("/api/GetT_Singlerows")]        
        public async Task<IActionResult> GetT_Singlerows(int page, int limit, int Auditstate, string Requisition="", string Tuneout="", string Transferred="")
        {      
            List<Singlerows> list =await GetWMSS.GetT_Singlerows();
            if (Auditstate != 0)
            {
                list = list.Where(x => x.Auditstate == Auditstate).ToList();
            }

            if (!string.IsNullOrEmpty(Requisition))
            {
                list = list.Where(x => x.Requisition == Requisition).ToList();
            }

            if (!string.IsNullOrEmpty(Tuneout))
            {
                list = list.Where(x => x.Tuneout.Contains(Tuneout)).ToList();
            }

            if (!string.IsNullOrEmpty(Transferred))
            {
                list = list.Where(x => x.Tuneout.Contains(Transferred)).ToList();
            }
            //list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData jsons = new JsonData { code = 0, msg = "", count = list.Count(), data = list };
            string json = JsonConvert.SerializeObject(jsons);       
            return Ok( json);
        }

        //调拨物品详情反填
        [HttpGet]
        [Route("/api/GetT_Merging")]
        public async Task<IActionResult> GetT_Merging(int MId1)
        {
            var list = await GetWMSS.GetT_Merging(MId1);
            string str = JsonConvert.SerializeObject(list);
            return Ok(str);
        }
        //调拨物品详情
        [HttpGet]
        [Route("/api/GetT_Merging1")]
        public async Task<IActionResult> GetT_Merging1(int page, int limit)
        {
            var list = await GetWMSS.GetT_Merging1();
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            var sum = list.Count();
            JsonData json = new JsonData { count = sum, code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }
        //补货需求详情
        [HttpGet]
        [Route("/api/GetT_Replenishments")]
        public async Task<IActionResult> GetT_Replenishments(int page, int limit)
        {
            var list = await GetWMSS.GetT_Replenishments();
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            var sum = list.Count();
            JsonData json = new JsonData { count = sum, code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }

        //调拨审核
        [HttpGet]
        [Route("/api/GetT_Orderdetail")]
        public async Task<IActionResult> GetT_Orderdetail(int page, int limit)
        {
            var list = await GetWMSS.GetT_Orderdetail();
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }

        //调拨查看
        [HttpGet]
        [Route("/api/GetT_Orderdetail1")]
        public async Task<IActionResult> GetT_Audits(int page, int limit)
        {
            var list = await GetWMSS.GetT_Audits();
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }
        //调拨发配区
        [HttpGet]
        [Route("/api/GetT_Distribution")]
        public async Task<IActionResult> GetT_Distribution(int page, int limit)
        {
            var list = await GetWMSS.GetT_Distribution();
            //list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }







    }
}
