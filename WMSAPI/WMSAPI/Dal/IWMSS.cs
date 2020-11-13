﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Dal
{
   public interface IWMSS
    {
        int Add(Warehous warehous);
        List<Warehous> GetWarehous();
        Task<List<Z_CaiCha>> AOGShowAsync(); //到货显示
        Task<List<Productlist>> CategoryAsync();//品类绑定
    }
}
