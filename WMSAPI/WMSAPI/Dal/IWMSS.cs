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
        int AddWarehous(Warehous warehous);
        //显示库区管理
        List<Goods> GetGoods();
    }
}
