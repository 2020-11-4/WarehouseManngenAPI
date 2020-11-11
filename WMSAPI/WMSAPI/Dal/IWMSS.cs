using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
    public interface IWMSS
    {
        Task<List<M_Mission>> GetMissions();
    }
}
