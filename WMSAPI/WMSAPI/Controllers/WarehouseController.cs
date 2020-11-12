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
        //添加仓库设置
        [HttpPost]
        [Route("/api/AddWarehuse")]
        public int AddWarehuse([FromForm]Warehous warehous) 
        {
            int i = _Wmss.AddWarehous(warehous);
            return i;
        }
    }
}
