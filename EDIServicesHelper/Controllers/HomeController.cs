using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDIServicesHelper.Models;

namespace EDIServicesHelper.Controllers
{
    public class HomeController : Controller
    {
        private EdiServiceEntities db = new EdiServiceEntities();

        public ActionResult Index()
        {
            Utils_GetProcessingDocs processingDoc = new Utils_GetProcessingDocs();

            using (SqlConnection conn = (db.Database.Connection as SqlConnection))
            {
                using (SqlCommand query = new SqlCommand("EXEC Utils_GetProcessingDocs 0", conn))
                {
                    if (conn.State != System.Data.ConnectionState.Open) conn.Open();

                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read()) { }

                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                processingDoc.Total = reader.GetInt32(0);
                                processingDoc.Incoming = reader.GetInt32(1);
                                processingDoc.MinDoc = reader.GetInt64(2);
                                processingDoc.MinDate = reader.GetDateTime(3);
                                processingDoc.MaxDoc = reader.GetInt64(4);
                                processingDoc.MaxDate = reader.GetDateTime(5);
                                processingDoc.Diff = reader.GetInt32(6);
                                processingDoc.Senders = reader.GetInt32(7);
                                processingDoc.LastFileSent = reader.GetDateTime(8);
                            }
                        }
                    }
                }
            }

            return View(processingDoc);
        }
    }
}