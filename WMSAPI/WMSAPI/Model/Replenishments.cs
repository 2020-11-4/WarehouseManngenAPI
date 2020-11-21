using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 补货需求列表
    /// </summary>
    public class Replenishments
    {
        [Key]
        public int IXD { get; set; }//主键Id序号
        public string  Replenishodd { get; set; }//补货单号
        public DateTime ReplenishDate { get; set; }//补货日期
    }
}
