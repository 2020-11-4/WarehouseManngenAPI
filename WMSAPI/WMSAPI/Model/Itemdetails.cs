using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 调拨物品详情
    /// </summary>
    public class Itemdetails
    {
        [Key]
        public int XID { get; set; }//主键Id序号
        public string Quantity { get; set; }//申请数量
        public string Approvalnumber { get; set; }//审批数量
        public string Turnoverbasket { get; set; }//已出库数量
        public string Image { get; set; }// 周转筐  
       
    }
}
