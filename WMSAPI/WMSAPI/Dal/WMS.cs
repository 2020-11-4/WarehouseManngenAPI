using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;
using System.Text.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace WMSAPI.Dal
{
    public class WMS : IWMSS
    {
        SqlSugarClient db = new SqlSugarClient(
            new ConnectionConfig
            {
                ConnectionString = "Data Source=10.3.38.27;Initial Catalog=Ware;User ID=sa;password=123",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

        //调拨单列表
        public async Task<List<Singlerows>> GetT_Singlerows()
        {
            var list = await (db.Queryable<Singlerows, Warehouse>((sl, wh) => new JoinQueryInfos(JoinType.Left, sl.IDX == wh.id))

                  .Select<Singlerows>().ToListAsync());

            //var list = await db.SqlQueryable<Singlerows>(@"select *from Singlerows inner join Warmarea on Singlerows.IDX=Warmarea.WWid")
            //    .ToListAsync();
            return list;
        }

        //调拨物品详情
        public async Task<List<Singlerows>> GetT_Merging(int MId1)
        {
            var list = await db.Queryable<Singlerows>()
            .Where(st => st.IDX == MId1)
            .Select<Singlerows>().ToListAsync();
            return list;
        }
        public async Task<List<Merging>> GetT_Merging1()
        {
            var list = await db.Queryable<Itemdetails, product>((it, su) => new JoinQueryInfos
           (
            JoinType.Left, it.XID == su.Product_Id
           ))
            .Select<Merging>().ToListAsync();
            return list;
        }

        //补货需求列表
        public async Task<List<Replenishments>> GetT_Replenishments()
        {
            var list = await db.Queryable<Replenishments>()
                .Select<Replenishments>().ToListAsync();
            return list;
        }
        //补货需求详情
        public async Task<List<Orderdetail>> GetT_Orderdetail()
        {
            var list = await db.Queryable<Replenishmentpp, Shang>((it, su) => new JoinQueryInfos(JoinType.Left, it.IDX == su.SId))
                 .Select<Orderdetail>().ToListAsync();
            return list;
        }
        //调出发配区
        public async Task<List<Distribution>> GetT_Distribution()
        {
            var list = await db.Queryable<Distribution,Material>((bt,mt) => new JoinQueryInfos
           (
             JoinType.Left, bt.QId == mt.Material_Id
           ))
           .Select<Distribution>().ToListAsync();
            return list;
        }
        //添加仓库
        public int Add(Warehouse Warehouse)
        {
            int list =  db.Insertable(Warehouse).ExecuteCommand();
            return list;
        }
        //出库记录
     
        public async Task<List<W_Warehuase>> GetGoods()
        {
            var list = await (db.Queryable<Goods, Warehouse, Warmarea>((g, h, w) => new JoinQueryInfos(
                JoinType.Left, g.Id == h.id,
                 JoinType.Left, h.WareId == w.WWid
              ))
           //.Where((g, h) => g.Rsesrvoirare == Rsesrvoirare && h.WarehouseName == WarehouseName )
           .Select<W_Warehuase>().ToListAsync()); ;
            return list;
        }

        //到货

        public async Task<List<Z_CaiCha>> AOGShowAsync()
        {
            var list = await (db.Queryable<Purchasing, Productlist, Supplierss>((st, sc, di) => new JoinQueryInfos(
              JoinType.Left,st.Supplier == sc.Pid,//可以用&&实现 on 条件 and
              JoinType.Left,st.Category == di.Sid
            ))
           //.Where((st,sc)=>sc.id>0) 多表条件用法
           .Select<Z_CaiCha>().ToListAsync());
            return  list;
        }
        
        //登记详情
        public async Task<List<Z_CaiCha>> RegistrationAsync(int XId)
        {
            var list =await (db.Queryable<Material, Purchasing>((st, sc) => new JoinQueryInfos(
                  JoinType.Left, st.MArrival == sc.Purchasing_Id
                  )).Where(st => st.MArrival == XId).Select<Z_CaiCha>().ToListAsync());

            return list;
        }

        //绑定库区
        public async Task<List<Warehouse>> ReserAsync()
        {
            var list =await db.Queryable<Warehouse>().ToListAsync();
            return list;
        }

        //绑定品类
        public async Task<List<Productlist>> CategoryAsync()
        {
            var list =await (db.Queryable<Productlist>().ToListAsync());
            return list;
        }

        //快捷到货
        public async Task<List<Supplies>> SwiftAsync()
        {

            var list =await  db.Queryable<Supplies>().ToListAsync();
            return list;
        }

        //快捷删除
        public async Task<int> DelkaiAsync(int DId)
        {
            var list =await  db.Deleteable<Supplies>().Where(st => st.Supplies_Id == DId).ExecuteCommandAsync();
            return list;
        }

        //到货记录
        public async Task<List<Z_Kuai>> ReceivingAsync()
        {
            var list =await  db.Queryable<Arrival, Purchasing, Supplierss, Productlist>((st, sc, sl, sq) => new JoinQueryInfos(
                        JoinType.Left, st.Anumbers == sc.Purchasing_Id,
                        JoinType.Left, sc.Supplier == sl.Sid,
                        JoinType.Left, sc.Category == sq.Pid
                     )).Select<Z_Kuai>().ToListAsync();

            return list;
        }

        //快捷到货登记
        public async Task<List<Material>> CheckinAsync()
        {
            var list =await  db.Queryable<Material>().ToListAsync();
            return list;
        }

        //绑定
        public async Task<List<Z_Kuai>> BindingAsync()
        {
            var list = await db.Queryable<Arrival, Purchasing, Supplierss>((st, sc, sl) => new JoinQueryInfos(
                      JoinType.Left, st.Anumbers == sc.Purchasing_Id,
                      JoinType.Left, sc.Supplier == sl.Sid
                   )).Select<Z_Kuai>().ToListAsync();

            return list;
        }

        //出库明细显示
        public async Task<List<ckmx>> Clibraryshow()
        {

            var list = await (db.Queryable<product, Warmarea, Supplierss>((st, sc, di) => new JoinQueryInfos(
               JoinType.Left, st.Pgoods == sc.WWid,//可以用&&实现 on 条件 and
               JoinType.Left, st.Product_Id == di.Sid
             ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<ckmx>().ToListAsync());

            return list;
        }
        //采购退货任务
        public async Task<List<CGreturned>> CGreturnedshow()
        {

            var list = await (db.Queryable<Mission, Purchasing, Supplierss, product>((st, sc, di, cp) => new JoinQueryInfos(
                JoinType.Left, st.Hid == sc.Purchasing_Id,//可以用&&实现 on 条件 and
                JoinType.Left, st.Sid == di.Sid,
                JoinType.Left, st.Mid == cp.Product_Id
              ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<CGreturned>().ToListAsync());

            return list;
        }

        //采购退货任务详情
        public async Task<List<particulars>> particularsshow()
        {

            var list = await (db.Queryable<product, Supplies>((st, sc) => new JoinQueryInfos(
                JoinType.Left, st.Pgoods == sc.Supplies_Id//可以用&&实现 on 条件 and
              ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<particulars>().ToListAsync());

            return list;
        }

        //产品出库任务详情
        public async Task<List<particulars>> CPoutshow()
        {

            var list = await (db.Queryable<product, Supplies>((st, sc) => new JoinQueryInfos(
                JoinType.Left, st.Pgoods == sc.Supplies_Id//可以用&&实现 on 条件 and
              ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<particulars>().ToListAsync());

            return list;
        }

        //库区绑定下拉
        public async Task<List<Warmarea>> KQbang()
        {

            var list = await db.Queryable<Warmarea>().ToListAsync();

            return list;
        }


        //添加出库任务
        public async Task<List<product>> outtask()
        {

            var list = await db.Queryable<product>().ToListAsync();

            return list;
        }

        //出库记录
        public async Task<List<ckjl>> CKrecord()
        {

            var list = await (db.Queryable<product, Inventorylist, Warehouse>((st, sc, cp) => new JoinQueryInfos(
                 JoinType.Left, st.Product_Id == sc.Inventorylist_NId,//可以用&&实现 on 条件 and
                 JoinType.Left, st.Pgoods == cp.id
               ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<ckjl>().ToListAsync());

            return list;
        }

        //添加盘点任务
        public int PDAdd(pandian Warehouse)
        {
            int list = db.Insertable(Warehouse).ExecuteCommand();
            return list;
        }

        //盘点任务管理未盘点
        public async Task<List<pandian>> panshow()
        {

            var list = await db.Queryable<pandian>().Where(it => it.psates.Contains("未盘点")).ToListAsync();

            return list;
        }

        //盘点任务管理已盘点
        public async Task<List<pandian>> panyshow()
        {

            var list = await db.Queryable<pandian>().Where(it => it.psates.Contains("已盘点")).ToListAsync();

            return list;
        }

        //未盘点详情
        public async Task<List<pandian>> xiangqing(int id)
        {

            var list = await db.Queryable<pandian>().Where(it=>it.pandian_id==id).ToListAsync();

            return list;
        }

        //产品显示
        public async Task<List<product>> CPshow()
        {

            var list = await db.Queryable<product>().ToListAsync();

            return list;
        }


        //绑定供应商
        public async Task<List<Supplierss>> ProviderAsync()
        {
            var list = await db.Queryable<Supplierss>().ToListAsync();
            return list;
        }
        //显示报损
        public async Task<List<FMmodel>> FMShow()
        {
            var list = await (db.Queryable<Warehouse, product, Frmlosses>((a, b, c) => new JoinQueryInfos(
               JoinType.Left, a.WareId == b.Product_Id,//可以用&&实现 on 条件 and
               JoinType.Left, a.WareId == c.ID
             ))
           //.Where((st,sc)=>sc.id>0) 多表条件用法
           .Select<FMmodel>().ToListAsync());
            return list;
        }

        public Task<List<Merging>> GetT_Audits()
        {
            throw new NotImplementedException();
        }
    }
}
