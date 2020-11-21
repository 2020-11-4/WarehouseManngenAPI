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
        
        [HttpGet]
        [Route("/api/GetT_Audits")]        
        public async Task<IActionResult> GetT_Audits(/*int page, int limit,*/int Auditstate, string Requisition, string Tuneout = "", string Transferred = "")
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
        [HttpGet]
        [Route("/api/GetT_Itemdetails")]
        public async Task<IActionResult> GetT_Itemdetails(int page,int limit)
        {
            var list = await GetWMSS.GetT_Merging();
            //list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }
        [HttpGet]
        [Route("/api/GetT_Replenishments")]
        public async Task<IActionResult> GetT_Replenishments(int page, int limit)
        {
            var list = await GetWMSS.GetT_Replenishments();
            //list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }


        [HttpGet]
        [Route("/api/GetT_Orderdetail")]
        public async Task<IActionResult> GetT_Orderdetail(int page, int limit)
        {
            var list = await GetWMSS.GetT_Orderdetail();
            //list = list.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData { count = list.Count(), code = 0, msg = "", data = list };
            string str = JsonConvert.SerializeObject(json);
            return Ok(str);
        }

    }
}
