using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
        //添加仓库设置
        Task<int>  AddWarehous(Warehous warehous);
        //显示库区管理
        Task<List<Goods>> GetGoods(string WarehouseName,string Rsesrvoirare);
        //删除库区管理
        Task<int> DelGoods(int GId);


    }
}
