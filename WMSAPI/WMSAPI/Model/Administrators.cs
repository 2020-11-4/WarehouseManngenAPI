using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 库管员管理
    /// </summary>
    public class Administrators
    {
        [Key]
        public int Aid { get; set; }//主键Id
        public string WarehouseName { get; set; }//仓库名称
        public string Name { get; set; }//姓名
        public string LoginPjone { get; set; }//登录手机号
        public DateTime CreateDate { get; set; }//创建时间
        public bool AState { get; set; }//状态
    }
}
