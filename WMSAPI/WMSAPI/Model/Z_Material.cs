using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Z_Material
    {
        /// <summary>
        /// 原料表
        /// </summary>

        [Key]
        public int Material_Id { get; set; }//主键


        [StringLength(20)]
        public string Mcoding { get; set; }//原料编码

        [StringLength(20)]
        public string MName { get; set; } //原料名称

        [StringLength(20)]
        public string Mwarm { get; set; } //存放温区

        [StringLength(50)]
        public string Mspecification { get; set; }//原料规格

        [StringLength(50)]
        public string Mquantity { get; set; } //采购数量

        [StringLength(30)]
        public string Mstorage { get; set; }//入库数量
    }
}
