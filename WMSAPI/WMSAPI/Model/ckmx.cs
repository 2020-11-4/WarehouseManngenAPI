using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class ckmx
    {
        public class product
        {
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
        }
        /// <summary>
        /// 仓库表
        /// </summary>
        public class Warehous
        {
            public int Wid { get; set; }//主键id
            public string SuperiorWarehouse { get; set; }//上级仓库
            public string WarehouseName { get; set; }//当前仓库名称
            public string WarehouseCode { get; set; }//仓库编号
            public int Arrangr { get; set; }//排序
            public string WarehuoseAddress { get; set; }//仓库地址
            public string DetailedAddress { get; set; }//详细地址
            public bool WarehouseEntities { get; set; }//实体仓库
            public bool State { get; set; }//当前状态
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public class Suppliers
        {
            public int Sid { get; set; }//供应商id
            public string Snumber { get; set; }//供应商编号
            public string SName { get; set; }//供应商名称
        }
    }
}
