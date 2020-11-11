using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 调拨单列表
    /// </summary>
    public class Singlerows
    {
        [Key]
        public int IDX { get; set; }  //序号       
        public int Requisition { get; set; }//调拨单号
        public string Tuneout { get; set; }//调出仓库
        public string Transferred { get; set; }//调入仓库
        public string Allocationdate { get; set; }//调拨日期
        public string Allotpeople { get; set; }//调拨人
        public int Auditstate { get; set; }//审核状态
        public int Allotcondition { get; set; }//调拨状态
        public int Framnumber { get; set; }//装框数量
    }
}
