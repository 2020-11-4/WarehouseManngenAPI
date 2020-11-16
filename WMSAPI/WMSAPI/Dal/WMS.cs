﻿using Microsoft.AspNetCore.Components;
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
        //private readonly string _connectionString;
        //public WMS(IConfiguration configuration) 
        //{
        //    _connectionString = configuration.GetConnectionString("SqlServerContext");
        //}

        SqlSugarClient db = new SqlSugarClient(
            new ConnectionConfig
            {
                ConnectionString = "Data Source=10.3.38.27;Initial Catalog=Ware;User ID=sa;password=123",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

        public int Add(Warehous warehous)
        {
            var list = db.Insertable(warehous).ExecuteCommand();
            return list;
        }

        public List<Warehous> GetWarehous()
        {
            List<Warehous> lint = db.Queryable<Warehous>().ToList();
            return lint;
        }

        //出库明细显示
        public async Task<List<ckmx>> Clibraryshow()
        {

            var list = await (db.Queryable<product, Warehous, Supplierss>((st, sc, di) => new JoinQueryInfos(
               JoinType.Left, st.Pgoods == sc.Wid,//可以用&&实现 on 条件 and
               JoinType.Left, st.Product_Id == di.Sid
             )).Select<ckmx>().ToListAsync()) ;

            return list;
        }
        public async Task<List<Z_CaiCha>> AOGShowAsync()
        {

            var list = await (db.Queryable<Purchasing,Productlist,Supplierss>((st, sc, di) => new JoinQueryInfos(
              JoinType.Left,st.Supplier == sc.Pid,//可以用&&实现 on 条件 and
              JoinType.Left,st.Category == di.Sid
            ))
           //.Where((st,sc)=>sc.id>-0) 多表条件用法
           .Select<Z_CaiCha>().ToListAsync());

            return  list;
        }
        //绑定产品品类
        public async Task<List<Productlist>> CategoryAsync()
        {
            var list = await (db.Queryable<Productlist>().ToListAsync());
            return list;
        }
    }
}
