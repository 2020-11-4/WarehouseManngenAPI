using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Dal
{
    public class WMS:IWMSS
    {
        private readonly string _connectionString;
        public WMS(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ZCY");
        }


    }
}
