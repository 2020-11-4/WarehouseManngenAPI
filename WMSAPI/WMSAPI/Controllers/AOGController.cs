using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMSAPI.Dal;
using WMSAPI.Helper;

namespace WMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AOGController : ControllerBase
    {
        private IWMSS _Wmss;
        public AOGController(IWMSS wmss)
        {
            _Wmss = wmss;
        }

        [HttpGet]
        [Route("/api/AOGShowAsync")]
        public async Task<IActionResult> AOGShowAsync(int page, int limit, string CDan, string CPin, string CGong, string CRen)
        {
            var AOGShow = await _Wmss.AOGShowAsync();

            if (!string.IsNullOrEmpty(CDan))
            {
                AOGShow = AOGShow.Where(st => st.Ordernumber.Contains(CDan)).ToList();
            }
            if (!string.IsNullOrEmpty(CPin))
            {
                AOGShow = AOGShow.Where(st => st.Classes==CPin).ToList();
            }
            if (!string.IsNullOrEmpty(CGong))
            {
                AOGShow = AOGShow.Where(s => s.SName.Contains(CGong)).ToList();
            }
            if (!string.IsNullOrEmpty(CRen))
            {
                AOGShow = AOGShow.Where(st => st.Agent == CRen).ToList();
            }

            var Count = AOGShow.Count;
            var liat = AOGShow.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);

        }

        //登记详情
        [HttpGet]
        [Route("/api/RegistrationAsync")]
        public async Task<IActionResult> RegistrationAsync(int XId)
        {
            var Registration = await _Wmss.RegistrationAsync(XId);
            string json = JsonConvert.SerializeObject(Registration);
            return Ok(json);
        }

        //绑定库区
        [HttpGet]
        [Route("/api/ReserAsync")]
        public async Task<IActionResult> ReserAsync()
        {
            var Reser = await _Wmss.ReserAsync();
            string json = JsonConvert.SerializeObject(Reser);
            return Ok(json);
        }

        //绑定品类
        [HttpGet]
        [Route("/api/CategoryAsync")]
        public async Task<IActionResult> CategoryAsync()
        {
            var category = await _Wmss.CategoryAsync();
            string json = JsonConvert.SerializeObject(category);
            return Ok(json);
        }

        //快捷到货
        [HttpGet]
        [Route("/api/SwiftAsync")]
        public async Task<IActionResult> SwiftAsync()
        {
            var Swift = await _Wmss.SwiftAsync();
            string json = JsonConvert.SerializeObject(Swift);
            return Ok(json);
        }

        //快捷删除
        [HttpPost]
        [Route("/api/DelkaiAsync")]
        public async Task<IActionResult> DelkaiAsync([FromForm]int DId)
        {
            var list = await _Wmss.DelkaiAsync(DId);

            return Ok(list);
        }

        //到货记录
        [HttpGet]
        [Route("/api/ReceivingAsync")]
        public async Task<IActionResult> ReceivingAsync(int page, int limit,string RDen,string RDan,string RSang,string RPin,string Ren)
        {
            var Receiving = await _Wmss.ReceivingAsync();

            if (!string.IsNullOrEmpty(RDen))
            {
                Receiving = Receiving.Where(st => st.Arrivalregistration.Contains(RDen)).ToList();
            }
            if (!string.IsNullOrEmpty(RDan))
            {
                Receiving = Receiving.Where(st => st.Ordernumber.Contains(RDan)).ToList();
            }
            if (!string.IsNullOrEmpty(RSang))
            {
                Receiving = Receiving.Where(st => st.SName.Contains(RSang)).ToList();
            }
            if (!string.IsNullOrEmpty(RPin))
            {
                int pin = Convert.ToInt32(RPin);
                Receiving = Receiving.Where(st => st.Pid == pin).ToList();
            }
            if (!string.IsNullOrEmpty(Ren))
            {
                Receiving = Receiving.Where(st => st.Agent.Contains(Ren)).ToList();
            }

            var Count = Receiving.Count;
            var liat = Receiving.Skip((page - 1) * limit).Take(limit).ToList();
            JsonData jsons = new JsonData { code = 0, msg = "", count = Count, data = liat };
            string json = JsonConvert.SerializeObject(jsons);
            return Ok(json);
        }

        //快捷到货登记
        [HttpGet]
        [Route("/api/CheckinAsync")]
        public async Task<IActionResult> CheckinAsync()
        {
            var Checkin = await _Wmss.CheckinAsync();
            string json = JsonConvert.SerializeObject(Checkin);
            return Ok(json);
        }

        //绑定
        [HttpGet]
        [Route("/api/BindingAsync")]
        public async Task<IActionResult> BindingAsync()
        {
            var Binding = await _Wmss.BindingAsync();
            string json = JsonConvert.SerializeObject(Binding);
            return Ok(json);
        }
    }
}
