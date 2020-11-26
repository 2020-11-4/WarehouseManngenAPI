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
        Task<List<FMmodel>> FMShow();
        //添加仓库设置
        int Add(Warehouse warehous);

        //添加盘点任务
        int PDAdd(pandian warehous);

        //盘点任务管理未盘点
        Task<List<pandian>> panshow();

        //产品显示
        Task<List<product>> CPshow();

        //盘点任务管理已盘点
        Task<List<pandian>> panyshow();

        //未盘点详情
        Task<List<pandian>> xiangqing(int id);

        //出库明细显示
        Task<List<ckmx>> Clibraryshow();

        //产品出库任务单详情
        Task<List<particulars>> CPoutshow();

        //出库记录
        Task<List<ckjl>> CKrecord();

        //采购退货任务
        Task<List<CGreturned>> CGreturnedshow();

        //库区绑定下拉
        Task<List<Warmarea>> KQbang();

        //添加出库任务
        Task<List<product>> outtask();

        //采购退货任务详情
        Task<List<particulars>> particularsshow();

        //显示仓库管理
        Task<List<W_Warehuase>> GetGoods();

    
        //Task<List<Goods>> GetGoods();

        Task<List<Supplierss>> ProviderAsync();//绑定供应商
        //添加管理员
        Task<int> AddAdministrators(Administrators administrators);

        //显示货物管理
        Task<List<G_Goodsallocation>> GetGoodsallocation();
        //显示库管员管理
        Task<List<Administrators>> GetAdministrators();
        //显示仓库权限
        Task<List<C_Controllership>> GetControllerships();
        //添加库区
        Task<int> AddGoods(Goods goods);
        //反填库区管理
        Task<List<W_Warehuase>> FanWarehous(int id);
    }
}
