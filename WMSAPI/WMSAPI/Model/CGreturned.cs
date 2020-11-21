using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class CGreturned
    {
        /// <summary>
        /// 任务表
        /// </summary>
        public int Mid { get; set; }//主键id
        public int Tasknumber { get; set; }//任务编号
        public DateTime MissionDate { get; set; }//任务下达时间
        public int sid { get; set; }//供应商Id
        public int Hid { get; set; }//货物Id
        public int Mint { get; set; }//完成情况
        /// <summary>
        /// 产品表
        /// </summary>
        public int Product_Id { get; set; } //主键

        public string PCategory { get; set; } //品类

        public string Pcoding { get; set; } //产品编码

        public string PName { get; set; } //产品名称

        public string Pspecification { get; set; } //产品规格

        public string Punit { get; set; } //计量单位

        public int Pamount { get; set; } //待入库量

        public int Pgoods { get; set; } //关联仓库表
        /// <summary>
        /// 采购表
        /// </summary>
        public int Purchasing_Id { get; set; } //主键

        public string Ordernumber { get; set; }//采购单号

        public int Supplier { get; set; }//供应商

        public int Category { get; set; }//品类

        public DateTime Purchasedate { get; set; }//采购日期

        public string Agent { get; set; }//采购人

        public int State { get; set; }//入库状态
        /// <summary>
        /// 供应商
        /// </summary>
        public int Sid { get; set; }//供应商id
        public string Snumber { get; set; }//供应商编号
        public string SName { get; set; }//供应商名称
    }
}
