using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class C_Controllership
    {
        public int Aid { get; set; }//主键Id
        public int Wid { get; set; }
        public int Kid { get; set; }
        public string Name { get; set; }//姓名
        public string LoginPjone { get; set; }//登录手机号
        public DateTime CreateDate { get; set; }//创建时间
        public bool AState { get; set; }//状态

        public int Gid { get; set; }//主键Id
        public int Id { get; set; }//仓库id
        public string Rsesrvoirare { get; set; }//库区
        public string DescriptionGoods { get; set; }//仓库代码

        public int id { get; set; }//主键id
        public string SuperiorWarehouse { get; set; }//上级仓库
        public string WarehouseName { get; set; }//当前仓库名称
        public string WarehouseCode { get; set; }//仓库编号
        public int Arrangr { get; set; }//排序
        public string WarehuoseAddress { get; set; }//仓库地址
        public string DetailedAddress { get; set; }//详细地址
        public bool WarehouseEntities { get; set; }//实体仓库
        public bool State { get; set; }//当前状态
        public int WareId { get; set; }//温区id
        public int Cid { get; set; }//货位表Id
    }
}
