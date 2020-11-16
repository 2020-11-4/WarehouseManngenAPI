using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class ckmx
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
        /// 货物表
        /// </summary>
        public int Gid { get; set; }//主键Id
        public int Id { get; set; }//仓库id
        public string Rsesrvoirare { get; set; }//库区
        public string DescriptionGoods { get; set; }//仓库代码
        /// <summary>
        /// 供应商
        /// </summary>
        public int Sid { get; set; }//供应商id
        public string Snumber { get; set; }//供应商编号
        public string SName { get; set; }//供应商名称
    }
}
