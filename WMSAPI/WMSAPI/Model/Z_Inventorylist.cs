using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Z_Inventorylist
    {
        /// <summary>
        /// 入库明细表
        /// </summary>

        [Key]
        public int Inventorylist_NId { get; set; } //主键

        public int Iwarehouse { get; set; } //入库仓库

        public int Icategory { get; set; } //货存类别

        public int Icoding { get; set; } //货存编码

        [StringLength(20)]
        public string Ibatch { get; set; }//批次号

        [StringLength(20)]
        public string Iarticle { get; set; } //存货名称

        [StringLength(20)]
        public string Iunload { get; set; } //卸货区域

        [StringLength(20)]
        public string Iunit { get; set; } //计量单位

        [StringLength(20)]
        public string Istoreroom { get; set; } //入库类型
    }
}
