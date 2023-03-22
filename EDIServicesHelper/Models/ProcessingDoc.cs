using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDIServicesHelper.Models
{
    public class Utils_GetProcessingDocs
    {
        public int Total { get; set; }
        public int Incoming { get; set; }
        public long MinDoc { get; set; }
        public DateTime MinDate { get; set; }
        public long MaxDoc { get; set; }
        public DateTime MaxDate { get; set; }
        public int Diff { get; set; }
        public int Senders { get; set; }
        public DateTime LastFileSent { get; set; }
    }
}