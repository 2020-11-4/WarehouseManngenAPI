using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 产品类别
    /// </summary>
    public class P_Product
    {
        [Key]
        public int Pid { get; set; }//主键id
        public string Classes { get; set; }//产品类别
        public string ProductCode { get; set; }//产品编号
        public string ProductName { get; set; }//产品名称
        public string ProductStandard { get; set; }//产品规格
        public string Measure { get; set; }//计量单位
        public int LnventorySettings { get; set; }//库存设置
    }
}
