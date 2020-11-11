using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
    public class WMS : IWMSS
    {
        private readonly string _connectionString;
        public WMS(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SqlServerContext");
        }


        public List<T_Itemdetails> GetItemdetails()
        {
            throw new NotImplementedException();
        }

        public List<T_replenishment> GetTreplenishments()
        {
            throw new NotImplementedException();
        }

        public List<T_single_row> GetTsingle_s()
        {
            throw new NotImplementedException();
        }

        public List<T_audit> Get_Audits()
        {
            throw new NotImplementedException();
        }
    }
}
