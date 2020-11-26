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
        [HttpPost]
        [Route("/api/Add")]
        public int Add([FromBody]Warehouse Warehouse) 
        {
            int i =  _Wmss.Add(Warehouse);
            return i;
        }
        //添加仓库管理
        [HttpGet]
        [Route("/api/GetGoods")]
        public async Task<IActionResult> GetGoods(string WarehouseName, string Rsesrvoirare, int page, int limit)
        {
            List<W_Warehuase> goods = await _Wmss.GetGoods();
            if (!string.IsNullOrEmpty(WarehouseName))
            {
                goods = goods.Where(s => s.WarehouseName == WarehouseName).ToList();
            }
            if (!string.IsNullOrEmpty(Rsesrvoirare))
            {
                goods = goods.Where(s => s.Rsesrvoirare == Rsesrvoirare).ToList();
            }
            int count = goods.Count();
            goods = goods.Skip((page - 1) * limit).Take(limit).ToList();
            string lint = JsonConvert.SerializeObject(new { count = count, code = 0, msg = "", data = goods });
            return Ok(lint);
        }

        //显示货位管理
        [HttpGet]
        [Route("/api/GetGoodsallocation")]
        public async Task<IActionResult> GetGoodsallocation(int page, int limit, string WarehouseName, string Rsesrvoirare)
        {
            List<G_Goodsallocation> list = await _Wmss.GetGoodsallocation();
            if (!string.IsNullOrEmpty(WarehouseName))
            {
                list = list.Where(s => s.WarehouseName.Contains(WarehouseName)).ToList();
            }
            if (!string.IsNullOrEmpty(Rsesrvoirare))
            {
                list = list.Where(s => s.Rsesrvoirare == Rsesrvoirare).ToList();
            }
            int count = list.Count;
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            string lint = JsonConvert.SerializeObject(list);
            JsonData json = new JsonData { count = count, code = 0, msg = "", data = list };
            return Ok(json);
        }
        /// <summary>
        /// 显示库员管理
        /// </summary>
        /// <param name="管理员项目"></param>
        /// <param name="手机号"></param>
        /// <param name="状态"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/GetAdministrators")]
        public async Task<IActionResult> GetAdministrators(string Name, bool AState, int page, int limit)
        {
            List<Administrators> list = await _Wmss.GetAdministrators();
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.Name == Name).ToList();
            }
            if (AState != false)
            {
                list = list.Where(s => s.AState == AState).ToList();
            }
            int count = list.Count;
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            string lint = JsonConvert.SerializeObject(list);
            JsonData json = new JsonData { count = count, code = 0, msg = "", data = list };
            return Ok(json);
        }
        //显示仓库权限
        [HttpGet]
        [Route("/api/GetControllerships")]
        public async Task<IActionResult> GetControllerships(int page, int limit, string WarehouseName, string LoginPjone)
        {
            List<C_Controllership> list = await _Wmss.GetControllerships();
            if (!string.IsNullOrEmpty(WarehouseName))
            {
                list = list.Where(s => s.WarehouseName.Contains(WarehouseName)).ToList();
            }
            if (!string.IsNullOrEmpty(LoginPjone))
            {
                list = list.Where(s => s.LoginPjone == LoginPjone).ToList();
            }
            int count = list.Count();
            list = list.Skip((page - 1) * limit).Take(limit).ToList();
            string josn = JsonConvert.SerializeObject(new { count = count, code = 0, msg = "", data = list });
            return Ok(josn);
        }
        //添加库区
        [HttpPost]
        [Route("/api/AddGoods")]
        public async Task<IActionResult> AddGoods([FromForm] Goods goods)
        {
            int i = await _Wmss.AddGoods(goods);
            return Ok(i);
        }
        //反填库区管理
        [Route("/api/FanWarehou")]
        [HttpGet]
        public async Task<IActionResult> FanWarehou(int id)
        {
            List<W_Warehuase> list = await _Wmss.FanWarehous(id);
            string json = JsonConvert.SerializeObject(list);
            return Ok(json);
        }
        //添加管理员
        [Route("/api/AddAdministrators")]
        [HttpPost]
        public async Task<IActionResult> AddAdministrators([FromBody] Administrators administrators)
        {
            int i = await _Wmss.AddAdministrators(administrators);
            return Ok(i);
        }


    }
}
