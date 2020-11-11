using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Purchasing
    {
        /// <summary>
        /// 采购表
        /// </summary>
        [Key]
        public int Purchasing_Id { get; set; } //主键

        [Required]
        [StringLength(20)]
        public string Ordernumber { get; set; }//采购单号


        public int Supplier { get; set; }//供应商


        public int Category { get; set; }//品类

        public DateTime Purchasedate { get; set; }//采购日期


        [Required]
        [StringLength(20)]
        public string Agent { get; set; }//采购人

        public int State { get; set; }//入库状态
    }
}
