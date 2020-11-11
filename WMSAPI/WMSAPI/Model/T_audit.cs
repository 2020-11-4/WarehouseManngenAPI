﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 调拨审核
    /// </summary>
    public class T_audit
    {
        public decimal Auditmoney { get; set; }//审批金额
        public bool Auditstatus { get; set; }//审核状态
        public string Auditopinion { get; set; }//审核意见
        public DateTime Allocationdate { get; set; }//审核时间
       
    }
}
