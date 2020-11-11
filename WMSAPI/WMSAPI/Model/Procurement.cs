using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WMSAPI.Model
{
    public class Procurement
    {
        /// <summary>
        /// 采购入库表
        /// </summary>

        [Key]
        public int Procurement_PId { get; set; } //主键


        public int PAOG { get; set; } //到货单号

        public int Purchase { get; set; } //采购订单号

        [StringLength(50)]
        public string Storagecontent { get; set; } //入库内容

        public int Inventorystatus { get; set; } //入库状态
    }
}
