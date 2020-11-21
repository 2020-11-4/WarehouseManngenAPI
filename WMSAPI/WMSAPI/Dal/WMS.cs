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
        public async Task< List<Singlerows>>GetT_Singlerows()
        {
            var list = await (db.Queryable<Singlerows, Warehouse>((sl, wh) => new JoinQueryInfos(JoinType.Left, sl.IDX == wh.id))
                  //.Where((sl, wh) => sl.IDX > 0).ToList();
                  .Select<Singlerows>().ToListAsync());

            //var list = await db.SqlQueryable<Singlerows>(@"select *from Singlerows inner join Warmarea on Singlerows.IDX=Warmarea.WWid")
            //    .ToListAsync();
            return list;
        }
         
        //调拨物品详情
        public async Task<List<Merging>> GetT_Merging()
        {
            //var list = await (db.Queryable<Itemdetails,product>((It,wh)=>new JoinQueryInfos(JoinType.Left,It.XID==wh.Product_Id))
            //    .Select<Itemdetails>().ToListAsync());
            var list = await db.Queryable<Itemdetails, product>((it,su)=>new JoinQueryInfos(JoinType.Left,it.XID==su.Product_Id))
                .Select<Merging>().ToListAsync();
            return list;
        }
        //补货需求列表
        public async Task<List<Replenishments>> GetT_Replenishments()
        {
            var list =await db.Queryable<Replenishments>()
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
        //调拨审核
        //public async Task<List<Audits>> GetT_Audits()
        //{
        //    throw new NotImplementedException();
        //}

        //添加仓库
        public int Add(Warehouse Warehouse)
        {
            int list =  db.Insertable(Warehouse).ExecuteCommand();
            return list;
        }
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

            //var list =await  db.Queryable<Supplies, Purchasing, Supplierss>((st, sc, sl) => new JoinQueryInfos(
            //              JoinType.Left, st.Munitprice == sc.Purchasing_Id,
            //              JoinType.Left, sc.Supplier == sl.Sid
            //        )).Select<Z_Kuai>().ToListAsync();

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

        public int AddWarehous(Warehouse warehous)
        {
            throw new NotImplementedException();
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
        //库区绑定下拉
        public async Task<List<Warmarea>> KQbang()
        {

            var list = await db.Queryable<Warmarea>().ToListAsync();

            return list;
        }

    }
}
