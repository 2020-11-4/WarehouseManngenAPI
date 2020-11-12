using LinqToDB;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
        //private  string _connectionString;
        //public WMS(IConfiguration configuration)
        //{
        //    _connectionString = configuration.GetConnectionString("swj");
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
        public async Task<int> AddWarehous(Warehous warehous)
        {
            int i =await db.Insertable(warehous).ExecuteCommandAsync();
            return i;
        }
        //删除库区管理
        public async Task<int> DelGoods(int GId)
        {
            int i = await db.Deleteable<Goods>().Where(new Goods() { Gid = GId }).ExecuteCommandAsync();
            return i;
        }

        //显示库区管理
        public async Task<List<Goods>> GetGoods(string WarehouseName, string Rsesrvoirare)
        {
            var list = db.Queryable<Goods, Warehous>((st, sc) => new JoinQueryInfos(
                JoinType.Left, st.Id == sc.Wid//可以用&&实现 on 条件 and
              ))
           .Where((st, sc) => st.Rsesrvoirare == "Rsesrvoirare" && sc.WarehouseName == "WarehouseName") //多表条件用法
           .Select<Goods>().ToListAsync();
            return  (await list);
        }
    }
}
