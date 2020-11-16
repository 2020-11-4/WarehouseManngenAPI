using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class Suppliers
    {
        [Key]
        public int Sid { get; set; }//供应商id
        [StringLength(30)]
        public string Snumber { get; set; }//供应商编号
        [StringLength(20)]
        public string SName { get; set; }//供应商名称
    }
}
