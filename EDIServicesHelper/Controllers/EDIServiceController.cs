using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDIServicesHelper.Models;

namespace EDIServicesHelper.Controllers
{
    public class EDIServiceController : Controller
    {
        private EdiServiceEntities db = new EdiServiceEntities();

        // GET: EDIService
        public ActionResult Index(long ft = 0)
        {
            TransmissionInfo transmission = new TransmissionInfo();

            if (ft == 0) return View(transmission);

            var fTransmission = (from f in db.FileTransmissions.AsNoTracking()
                                 join source in db.TradingPartners.AsNoTracking() on f.SourceTP equals source.TradingPartnerID
                                 join dest in db.TradingPartners.AsNoTracking() on f.DestTP equals dest.TradingPartnerID
                                 join channel in db.TransmissionChannels.AsNoTracking() on f.TransmissionChannelID equals channel.TransmissionChannelID into TChannels
                                 from tc in TChannels.DefaultIfEmpty()
                                 where f.FileTransmissionID == ft
                                 select new
                                 {
                                     FileTransmission = f,
                                     Source = source,
                                     Destination = dest,
                                     TransmissionChannel = tc
                                 }).FirstOrDefault();

            if (fTransmission != null)
            {
                transmission.FileTransmission = fTransmission.FileTransmission;
                transmission.Source = fTransmission.Source;
                transmission.Destination = fTransmission.Destination;
                transmission.TransmissionChannel = fTransmission.TransmissionChannel;
                transmission.Documents = fTransmission.FileTransmission.Documents.ToList();
                transmission.ActionHistories = fTransmission.FileTransmission.Documents.SelectMany(d => d.ActionHistories).ToList();

                return View(transmission);
            }
            else
            {
                ViewBag.Message = string.Format("<b>Error Message:</b> transmission " + ft.ToString() + " not found in database.");
                return View(new TransmissionInfo());
            }
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            long ft = 0;
            if (Int64.TryParse(form["TransmissionID"], out ft))
            {
                return Index(ft);
            }

            ViewBag.Message = string.Format("<b>Error Message:</b> incorrect value for transmission ID.");
            return Index();
        }

        public FilePathResult DownloadFTFile(long ft)
        {
            string FilesPath = Server.MapPath("~/Files");

            FileTransmission transmission = db.FileTransmissions.AsNoTracking().Where(f => f.FileTransmissionID == ft).FirstOrDefault();
            string filePath = string.Format(@"{0}\{1}", FilesPath, transmission.FileName);

            if (!Directory.Exists(FilesPath))
            {
                Directory.CreateDirectory(FilesPath);
            }

            if (transmission.FileName.Contains(".xls"))
                System.IO.File.WriteAllBytes(filePath, Convert.FromBase64String(transmission.FileContents));
            else
                System.IO.File.WriteAllText(filePath, transmission.FileContents);

            return new FilePathResult(filePath, System.Net.Mime.MediaTypeNames.Application.Octet);
        }
    }
}