using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDIServicesHelper.Models
{
    public class PartnershipInfo
    {
        public int SlaveID { get; set; }
        public string SlaveName { get; set; }
        public int MasterID { get; set; }
        public string MasterName { get; set; }
    }
}