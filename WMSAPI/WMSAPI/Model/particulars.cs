using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class particulars
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
        /// <summary>
        /// 物料表
        /// </summary>

        public int Supplies_Id { get; set; }//主键

        public string Materialcode { get; set; } //物料编码

        public int GS1 { get; set; } //GS1编码

        public string MaName { get; set; } //物料名称

        public string MAttribute { get; set; } //物料属性

        public string Mspecification { get; set; } //物料规格

        public string MUnit { get; set; } //计量单位

        public string MQuantity { get; set; } //采购数量

        public string Mlasttoy { get; set; } //上次购价

        public int Munitprice { get; set; } //采购单价

        public DateTime Mdateproduced { get; set; }//生产日期

        public int Mrequiredtime { get; set; } //需求时间

        public int Mremark { get; set; } //备注
    }
}
