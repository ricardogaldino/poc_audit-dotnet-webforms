using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoC.ClientRequestAudit.WebForms.ViewModels
{
    public class AuditViewModel
    {
        public string Browser { get; set; }
        public string IPAddress { get; set; }
        public string OperatingSystem { get; set; }
        public bool IsMobileDevice { get; set; }

    }
}