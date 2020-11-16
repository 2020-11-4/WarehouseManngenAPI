using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1;
using WMSAPI.Dal;
using WMSAPI.Helper;
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
        public int Add([FromBody]Warehouse Warehouse) 
        {
            int i =  _Wmss.Add(Warehouse);
            return i;
        }
        //显示库区管理
        [HttpGet]
        [Route("/api/GetGoods")]
        public async Task<IActionResult> GetGoods(int page,int limit) 
        {
            List<W_Warehuase> goods = await _Wmss.GetGoods();
            string lint = JsonConvert.SerializeObject(goods);
            var count = goods.Count;
            goods = goods.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData json = new JsonData() { code = 0, msg = "", count = count + 1, data = goods };
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
