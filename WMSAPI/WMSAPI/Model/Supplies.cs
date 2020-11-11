using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Supplies
    {
        /// <summary>
        /// 物料表
        /// </summary>

        [Key]
        public int Supplies_Id { get; set; }//主键

        [StringLength(20)]
        public string Materialcode { get; set; } //物料编码


        public int GS1 { get; set; } //GS1编码

        [StringLength(20)]
        public string MaName { get; set; } //物料名称

        [StringLength(20)]
        public string MAttribute { get; set; } //物料属性

        [StringLength(20)]
        public string Mspecification { get; set; } //物料规格

        [StringLength(20)]
        public string MUnit { get; set; } //计量单位

        [StringLength(30)]
        public string MQuantity { get; set; } //采购数量

        [StringLength(20)]
        public string Mlasttoy { get; set; } //上次购价


        public int Munitprice { get; set; } //采购单价

        public DateTime Mdateproduced { get; set; }//生产日期


        public int Mrequiredtime { get; set; } //需求时间

        [StringLength(50)]
        public int Mremark { get; set; } //备注
    }
}
