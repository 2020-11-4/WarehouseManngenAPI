using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 管理权限
    /// </summary>
    public class P_Privilege
    {
        [Key]
        public int Pid { get; set; }//主键id
        public int KId { get; set; }//库存Id
        public int AId { get; set; }//姓名id
    }
}
