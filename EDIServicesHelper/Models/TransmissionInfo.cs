using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDIServicesHelper.Models
{
    public class TransmissionInfo
    {
        public FileTransmission FileTransmission { get; set; }
        public TradingPartner Source { get; set; }
        public TradingPartner Destination { get; set; }
        public TransmissionChannel TransmissionChannel { get; set; }
        public List<DocumentAction> DocumentActions { get; set; }
        public List<ActionHistory> ActionHistories { get; set; }
        public List<Document> Documents { get; set; }
    }
}