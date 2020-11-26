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
        /// <summary>
        /// 单列表
        /// </summary>
        [Key]
        public int IDX { get; set; }  //主键Id序号      
        public string Requisition { get; set; }//调拨单号
        public string Tuneout { get; set; }//调出仓库
        public string Transferred { get; set; }//调入仓库
        public string Allocationdate { get; set; }//调拨日期
        public string Allotpeople { get; set; }//调拨人
        public int Auditstate { get; set; }//审核状态
        public int Allotcondition { get; set; }//调拨状态
        public int Framnumber { get; set; }//装框数量

        [Key]
        public int Id { get; set; }//主键Id序号
        public int LId { get; set; }//关联键
        public int Sum { get; set; }//待审核调拨状态总数
        public decimal Auditmoney { get; set; }//审批金
        public bool Auditstatus { get; set; }//审核状态
        public string Auditopinion { get; set; }//审核意见
        //public DateTime Allocationdate { get; set; }//审核时间
    }
}
