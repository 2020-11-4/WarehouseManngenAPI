using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 货物表
    /// </summary>
    public class Goods
    {
        [Key]
        public int Gid { get; set; }//主键Id
        public int Id { get; set; }//仓库id
        public string Rsesrvoirare { get; set; }//库区
        public string DescriptionGoods { get; set; }//仓库代码
    }
}
