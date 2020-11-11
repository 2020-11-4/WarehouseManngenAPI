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
            _connectionString = configuration.GetConnectionString("shenwenjie");
        }

        public Task<List<M_Mission>> GetMissions()
        {
            throw new NotImplementedException();
        }
    }
}
