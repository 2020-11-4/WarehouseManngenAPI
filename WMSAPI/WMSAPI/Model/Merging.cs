using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Merging
    {
        /// <summary>
        /// 产品表
        /// </summary>

        [Key]
        public int Product_Id { get; set; } //主键

        [StringLength(20)]
        public string PCategory { get; set; } //品类

        [StringLength(20)]
        public string Pcoding { get; set; } //产品编码

        [StringLength(20)]
        public string PName { get; set; } //产品名称

        [StringLength(20)]
        public string Pspecification { get; set; } //产品规格

        [StringLength(20)]
        public string Punit { get; set; } //计量单位


        public int Pamount { get; set; } //待入库量
        public int Pgoods { get; set; } //关联仓库表


        /// <summary>
        /// 调拨物品详情
        /// </summary>
        [Key]
        public int XID { get; set; }//主键Id序号
        public string Quantity { get; set; }//申请数量
        public string Approvalnumber { get; set; }//审批数量
        public string Turnoverbasket { get; set; }//已出库数量
        public string Image { get; set; }// 周转筐  
    }
}
