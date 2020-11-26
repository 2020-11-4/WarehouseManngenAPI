using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class FMmodel
    {
        public int ID { get; set; }
        public string FrmlossID { get; set; } //报损编号

        public DateTime FrmlossTime { get; set; }//报损时间
        public string FrmlossNum { get; set; }//报损数量
        public string FrmlossAudit { get; set; }//报损审核
        public string FrmlossHandle { get; set; }//报损处理

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


        public int Product_Id { get; set; } //主键


        public string PCategory { get; set; } //品类


        public string Pcoding { get; set; } //产品编码


        public string PName { get; set; } //产品名称


        public string Pspecification { get; set; } //产品规格


        public string Punit { get; set; } //计量单位


        public int Pamount { get; set; } //待入库量
        public int Pgoods { get; set; } //关联仓库表
    }
}
