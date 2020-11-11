using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 仓库表
    /// </summary>
    public class Warehous
    {
        [Key]
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
}
