using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    public class Frmloss
    {
       /// <summary>
       /// 报损表
       /// </summary>
        public int ID { get; set; }//主键
        public string FrmLossID { get; set; }//报损ID
        public DateTime FrmLossTime { get; set; }//有效日期
        public string FrmLossNum { get; set; }//报损数量
        public string FrmLossAudit { get; set; }//报损审核状态
        public string FrmLossHandle { get; set; }//报损处理
    }
}
