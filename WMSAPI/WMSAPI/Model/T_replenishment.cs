using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 补货需求列表
    /// </summary>
    public class T_replenishment
    {
        public int IDX { get; set; }//序号
        public int Replenishodd { get; set; }//补货单号
        public int ReplenishDate { get; set; }//补货日期
    }
}
