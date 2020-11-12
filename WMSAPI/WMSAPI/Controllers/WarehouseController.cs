using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1;
using WMSAPI.Dal;
using WMSAPI.Model;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private IWMSS _Wmss;
        public WarehouseController(IWMSS wmss)
        {
            _Wmss = wmss;
        }
        ////添加仓库设置
        //[HttpPost]
        //[Route("/api/AddWarehuse")]
        //public async Task<IActionResult> AddWarehuse([FromForm] Warehous warehous)
        //{
        //    var i = await _Wmss.AddWarehous(warehous);
        //    return i;
        //}
        //显示库区管理
        [HttpGet]
        [Route("/api/GetGoods")]
        public string GetGoods(string WarehouseName, string Rsesrvoirare) 
        {
            var list = _Wmss.GetGoods(WarehouseName,Rsesrvoirare);
            string json = JsonConvert.SerializeObject(list);
            return json;
        }
    }
}
