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

        public int Add(W_Warehous warehous)
        {
            var list = db.Insertable(warehous).ExecuteCommand();
            return list;
        }
    }
}
