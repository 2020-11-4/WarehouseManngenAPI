using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Z_CaiCha
    {
        /// <summary>
        /// 采购表
        /// </summary>
        public int Purchasing_Id { get; set; } //主键
        public string Ordernumber { get; set; }//采购单号
        public int Supplier { get; set; }//供应商 关联供应商表
        public int Category { get; set; }//品类 关联品类表
        public DateTime Purchasedate { get; set; }//采购日期
        public string Agent { get; set; }//采购人
        public int State { get; set; }//入库状态

        /// <summary>
        /// 产品类别
        /// </summary>
        public int Pid { get; set; }//主键id
        public string Classes { get; set; }//产品类别
        public string ProductCode { get; set; }//产品编号
        public string ProductName { get; set; }//产品名称
        public string ProductStandard { get; set; }//产品规格
        public string Measure { get; set; }//计量单位
        public int LnventorySettings { get; set; }//库存设置

        /// <summary>
        /// 供应商
        /// </summary>
        public int Sid { get; set; }//供应商id
        public int Snumber { get; set; }//供应商编号
        public int SName { get; set; }//供应商名称
    }
}
