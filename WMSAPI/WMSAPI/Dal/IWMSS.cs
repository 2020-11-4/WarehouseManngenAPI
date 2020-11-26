using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
        //调拨审核
        Task<List<Merging>> GetT_Audits();
        //调拨物品详情
        Task<List<Singlerows>> GetT_Merging(int MId);
        Task<List<Merging>> GetT_Merging1();
        //补货需求列表
        Task<List<Replenishments>> GetT_Replenishments();
        //补货需求详情
        Task<List<Orderdetail>> GetT_Orderdetail();
        //调拨单列表
        Task<List<Singlerows>> GetT_Singlerows();
        //调出发配区
        Task<List<Distribution>> GetT_Distribution();



        Task<List<Z_CaiCha>> AOGShowAsync();
        Task<List<Z_Kuai>> ReceivingAsync();
        Task<List<Warehouse>> ReserAsync();
        Task<List<Z_Kuai>> BindingAsync();
        Task<List<Material>> CheckinAsync();
        Task<int> DelkaiAsync(int DId);
        Task<List<Supplies>> SwiftAsync();
        Task<List<Productlist>> CategoryAsync();
        Task<List<Z_CaiCha>> RegistrationAsync(int XId);










        //添加仓库设置
        int AddWarehous(Warehouse warehous);
        //显示库区管理
        //Task<List<Goods>> GetGoods();
        int Add(Warehouse Warehouse);
        //出库明细显示
        Task<List<ckmx>> Clibraryshow();
        //库区绑定下拉
        Task<List<Warmarea>> KQbang();
        //采购退货任务
        Task<List<CGreturned>> CGreturnedshow();
        //采购退货任务详情
        Task<List<particulars>> particularsshow();
        Task<List<Supplierss>> ProviderAsync();//绑定供应商
    }
}
