using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
         //调拨单列表
         List<T_Itemdetails> GetItemdetails();
         //调拨物品详情
         List<T_replenishment> GetTreplenishments();
         //补货表
         List<T_single_row> GetTsingle_s();
         //调拨审核
         List<T_audit> Get_Audits();
    }
}
