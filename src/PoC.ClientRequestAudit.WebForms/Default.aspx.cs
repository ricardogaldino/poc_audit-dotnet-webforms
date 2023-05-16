using PoC.ClientRequestAudit.WebForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoC.ClientRequestAudit.WebForms
{
    public partial class _Default : Page
    {
        public AuditViewModel ViewModel { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewModel = new AuditViewModel()
            {
                Browser = Request.Browser.Browser,
                IPAddress = Request.UserHostAddress,
                OperatingSystem = Request.Browser.Platform,
                IsMobileDevice = Request.Browser.IsMobileDevice
            };

        }
    }
}