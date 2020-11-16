using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
        int Add(Warehous warehous);
        List<Warehous> GetWarehous();
        //出库明细显示
        Task<List<ckmx>> Clibraryshow();

        Task<List<Z_CaiCha>> AOGShowAsync(); //

        Task<List<Productlist>> CategoryAsync();//品类绑定

    }
}
