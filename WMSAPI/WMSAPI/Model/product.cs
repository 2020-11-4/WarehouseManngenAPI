using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WMSAPI.Model
{
    public class product
    {
        /// <summary>
        /// 产品表
        /// </summary>

        [Key]
        public int Product_Id { get; set; } //主键

        [StringLength(20)]
        public string PCategory { get; set; } //品类

        [StringLength(20)]
        public string Pcoding { get; set; } //产品编码

        [StringLength(20)]
        public string PName { get; set; } //产品名称

        [StringLength(20)]
        public string Pspecification { get; set; } //产品规格

        [StringLength(20)]
        public string Punit { get; set; } //计量单位


        public int Pamount { get; set; } //待入库量
        public int Pgoods { get; set; } //关联仓库表
    }
}
