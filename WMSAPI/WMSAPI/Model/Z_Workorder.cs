using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Z_Workorder
    {
        /// <summary>
        /// 入库任务单表
        /// </summary>

        [Key]
        public int workorder_Id { get; set; } //主键

        [StringLength(30)]
        public string Wodd { get; set; } //入库单号

        public int warm { get; set; } //温区

        public int Wcount { get; set; } //任务数量

        [StringLength(30)]
        public string Wtype { get; set; } //入库物品类型

        [StringLength(20)]
        public string WName { get; set; } //添加人

        public DateTime Wtime { get; set; } //任务下达时间


        public string Wcommodity { get; set; } //入库物品
    }
}
