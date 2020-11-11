using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 任务表
    /// </summary>
    public class M_Mission
    {
        public int Mid { get; set; }//主键id
        public int Tasknumber { get; set; }//任务编号
        public DateTime MissionDate { get; set; }//任务下达时间
        public int Sid { get; set; }//供应商Id
        public int Hid { get; set; }//货物Id
        public int Mint { get; set; }//完成情况
    }
}
