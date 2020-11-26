using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class pandian
    {
        /// <summary>
        /// 盘点表
        /// </summary>
        public int pandian_id { get; set; }
        public string pname { get; set; }
        public string pwarehouse { get; set; }
        public string parea { get; set; }
        public string ptime { get; set; }
        public string pren { get; set; }
        public string pbei { get; set; }
        public string psates { get; set; }
        public int pwj { get; set; }
        public string pdanhao { get; set; }
    }
}
