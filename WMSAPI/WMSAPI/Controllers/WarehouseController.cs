﻿using System;
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

        [HttpPost]
        [Route("/api/Add")]
        public int Add(Warehous warehous) 
        {
            int i = _Wmss.Add(warehous);
            return i;
        }
        [HttpGet]
        [Route("/api/GetShow")]
        public string GetShow() 
        {
            List<Warehous> list = _Wmss.GetWarehous();
            var str = JsonConvert.SerializeObject(list);
            return str;
        }
    }
}