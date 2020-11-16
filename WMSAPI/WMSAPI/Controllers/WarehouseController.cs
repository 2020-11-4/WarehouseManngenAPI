using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        //添加仓库管理
        [HttpPost]
        [Route("/api/Add")]
        public async Task<int> Add(Warehous warehous) 
        {
            int i = await _Wmss.Add(warehous);
            return i;
        }
        //显示库区管理
        [HttpGet]
        [Route("/api/GetGoods")]
        public async Task<IActionResult> GetGoods(string Rsesrvoirare, string WarehouseName) 
        {
            List<Goods> goods = await _Wmss.GetGoods(Rsesrvoirare,WarehouseName);
            string lint = JsonConvert.SerializeObject(goods);
            return Ok(lint);
        }
        //删除库区管理
        public async Task<IActionResult> DelGoods(int id) 
        {
            int i = await _Wmss.DelGoods(id);
            return Ok(i);
        }
    }
}
