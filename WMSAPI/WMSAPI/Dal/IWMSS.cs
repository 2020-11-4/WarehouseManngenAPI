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
        Task<int> Add(Warehous warehous);
        //出库明细显示
        Task<List<ckmx>> Clibraryshow();

        Task<List<Z_CaiCha>> AOGShowAsync();

        //显示仓库管理
        Task<List<W_Warehuase>> GetGoods();
        //删除
        Task<int> DelGoods(int id);
    }
}
