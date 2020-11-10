using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMSAPI.Dal;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WMSControllers : ControllerBase
    {
        private IWMSS _Wmss;
        public WMSControllers(IWMSS wmss) 
        {
            _Wmss = wmss;
        }
    }
}
