using LinqToDB;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

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
        //添加仓库设置
        public int AddWarehous(Warehous warehous)
        {
            int i = db.Insertable(warehous).ExecuteCommand();
            return i;
        }
        //显示库区管理
        public List<Goods> GetGoods()
        {
            var list = db.Queryable<Goods, Warehous>((st, sc) => new JoinQueryInfos(
                JoinType.Left, st.Id == sc.Wid//可以用&&实现 on 条件 and
              ))
           //.Where((st,sc)=>sc.id>0) 多表条件用法
           .Select<Goods>().ToList();
            return  list;
        }
    }
}
