using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WMSAPI.Model
{
    public class Z_Arrival
    {
        /// <summary>
        /// 到货表
        /// </summary>

        [Key]
        public int Arrival_Id { get; set; } //主键

        [StringLength(30)]
        public string Arrivalregistration { get; set; } //到货登记号


        public int Anumbers { get; set; } //采购单号


        public int Asupplier { get; set; } //供货商


        public int Acategory { get; set; } //品类

        [StringLength(20)]
        public string Atype { get; set; } //产品类型

        public DateTime Adelivery { get; set; } //到货日期

        [StringLength(20)]
        public string AddType { get; set; } //添加类型


    }
}
