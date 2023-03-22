using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDIServicesHelper.Models;

namespace EDIServicesHelper.Controllers
{
    public class PartnershipController : Controller
    {
        private EdiServiceEntities db = new EdiServiceEntities();

        // GET: Partnership
        public ActionResult Index()
        {
            return View();            
        }

        [HttpPost]
        public JsonResult GetSlave(string slaveTerm = "", int masterID = 0)
        {
            List<PartnershipInfo> partnerhipList = (from p in db.Partnerships.AsNoTracking()
                                                    join slave in db.TradingPartners.AsNoTracking() on p.SlaveTradingPartner equals slave.TradingPartnerID
                                                    where slave.TradingPartnerName.Contains(slaveTerm) && (masterID == 0 || p.MasterTradingPartner == masterID)
                                                    select new PartnershipInfo()
                                                    {
                                                        SlaveID = slave.TradingPartnerID,
                                                        SlaveName = slave.TradingPartnerName
                                                    }).Distinct().ToList();

            return Json(partnerhipList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetMaster(string masterTerm = "", int slaveID = 0)
        {
            List<PartnershipInfo> partnerhipList = (from p in db.Partnerships.AsNoTracking()
                                                    join master in db.TradingPartners.AsNoTracking() on p.MasterTradingPartner equals master.TradingPartnerID                                                   
                                                    where master.TradingPartnerName.Contains(masterTerm) && (slaveID == 0 || p.SlaveTradingPartner == slaveID)
                                                    select new PartnershipInfo()
                                                    {
                                                        MasterID = master.TradingPartnerID,
                                                        MasterName = master.TradingPartnerName
                                                    }).Distinct().ToList();

            return Json(partnerhipList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SetViewBag(string value)
        {
            ViewBag.Message = "Record Inserted successfully";
            ModelState.Clear();
            return new EmptyResult();
        }
    }
}