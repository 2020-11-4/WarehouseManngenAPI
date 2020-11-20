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

        //添加仓库
        public int Add(Warehouse Warehouse)
        {
            int list =  db.Insertable(Warehouse).ExecuteCommand();
            return list;
        }


        //出库明细显示
        public async Task<List<ckmx>> Clibraryshow()
        {

            var list = await (db.Queryable<product, Warehous, Supplierss, Inventorylist>((st, sc, di,mx) => new JoinQueryInfos(
               JoinType.Left, st.Product_Id == sc.Wid,//可以用&&实现 on 条件 and
               JoinType.Left, st.Product_Id == di.Sid,
               JoinType.Left, st.Product_Id == mx.Inventorylist_NId
             ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<ckmx>().ToListAsync()) ;

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
    }
}
