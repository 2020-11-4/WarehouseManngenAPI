using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Z_Kuai
    {

        /// <summary>
        /// 到货表
        /// </summary>
        public int Arrival_Id { get; set; } //主键
        public string Arrivalregistration { get; set; } //到货登记号
        public int Anumbers { get; set; } //采购单号
        public string Atype { get; set; } //产品类型
        public DateTime Adelivery { get; set; } //到货日期
        public string AddType { get; set; } //添加类型

        /// <summary>
        /// 供应商Supplierss
        /// </summary>
        public int Sid { get; set; }//供应商id
        public string Snumber { get; set; }
        public string SName { get; set; }//供应商名称


        /// <summary>
        /// 采购表Purchasing
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
    }
}
