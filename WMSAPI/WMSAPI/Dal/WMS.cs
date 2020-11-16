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
        public async Task<int> Add(Warehous warehous)
        {
            var list = await db.Insertable(warehous).ExecuteCommandAsync();
            return list;
        }


        //出库明细显示
        public async Task<List<ckmx>> Clibraryshow()
        {

            var list = await (db.Queryable<product, Warehous, Suppliers, Inventorylist>((st, sc, di,mx) => new JoinQueryInfos(
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

            var list = await (db.Queryable<Purchasing, Productlist,Suppliers>((st, sc, di) => new JoinQueryInfos(
              JoinType.Left,st.Supplier == sc.Pid,//可以用&&实现 on 条件 and
              JoinType.Left,st.Category == di.Sid
            ))
           //.Where((st,sc)=>sc.id>0) 多表条件用法
           .Select<Z_CaiCha>().ToListAsync());

            return  list;
        }

        public async Task<List<W_Warehuase>> GetGoods()
        {
            var list = await (db.Queryable<Goods, Warehous, Warmarea>((g, h,w) => new JoinQueryInfos(
                JoinType.Left, g.Id == h.Wid,
                 JoinType.Left, h.WareId == w.WWid
              ))
           //.Where((g, h) => g.Rsesrvoirare == Rsesrvoirare && h.WarehouseName == WarehouseName )
           .Select<W_Warehuase>().ToListAsync()); ;
            return list;
        }

        public async Task<int> DelGoods(int id)
        {
            var aa =await db.Deleteable<Goods>().Where(it => it.Gid == id).ExecuteCommandAsync();

            return aa;
        }
    }
}
