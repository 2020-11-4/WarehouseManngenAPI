using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSAPI.Model
{
    /// <summary>
    /// 报损
    /// </summary>
    public class Frmlosses
    {
        public int ID { get; set; }
        public string FrmlossesID { get; set; }
        public DateTime FrmlossesTime { get; set; }
        public string FrmlossesNum { get; set; }
        public string FrmlossesAudit { get; set; }
        public string FrmlossesHandle { get; set; }
    }
}
