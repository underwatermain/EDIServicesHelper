using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDIServicesHelper.Models;

namespace EDIServicesHelper
{
    public static class EDIDatabaseTools
    {
        private static EdiServiceEntities db = new EdiServiceEntities();
        public static List<ActionHistory> GetActionHistory(long ftID)
        {
            return db.ActionHistories.Where(ah => ah.DocumentID == ftID).ToList();
        }
    }
}