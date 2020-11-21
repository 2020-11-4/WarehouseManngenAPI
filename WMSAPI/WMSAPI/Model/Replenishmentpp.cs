using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Replenishmentpp
    {
        /// <summary>
        /// 补货需求表
        /// </summary>
        public int    IDX { get; set; }//一级品类
        public string Epmi { get; set; }
        public string Specification { get; set; }
        public string Price { get; set; }
        public decimal Amount { get; set; }
        public int    AvailableStock { get; set; }
        public string Totalreplenishment { get; set; }
        public string Audit { get; set; }
        public string Reviewof { get; set; }
        public string Comparisonof { get; set; }
        public bool   Onoff { get; set; }

    }
}
