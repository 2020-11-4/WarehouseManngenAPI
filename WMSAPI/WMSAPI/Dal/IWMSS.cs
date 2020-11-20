using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;
using static WMSAPI.Model.ckmx;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
        int Add(Warehouse Warehouse);
        //出库明细显示
        Task<List<ckmx>> Clibraryshow();
        //Z
        Task<List<Z_CaiCha>> AOGShowAsync(); //到货
        Task<List<Z_CaiCha>> RegistrationAsync(int XId);//登记详情
        Task<List<Warehouse>> ReserAsync();//绑定库区
        Task<List<Productlist>> CategoryAsync();//绑定品类
        Task<List<Supplies>> SwiftAsync();//快捷到货
        Task<int> DelkaiAsync(int DId);//快捷删除
        Task<List<Z_Kuai>> ReceivingAsync();//到货记录
        Task<List<Material>> CheckinAsync();//快捷到货登记
        Task<List<Z_Kuai>> BindingAsync();//绑定

        //显示仓库管理
        Task<List<W_Warehuase>> GetGoods();
    }
}
