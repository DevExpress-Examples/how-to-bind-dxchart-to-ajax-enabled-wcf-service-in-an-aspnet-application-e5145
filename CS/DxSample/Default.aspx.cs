using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DxSample
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.ClientScript.IsStartupScriptRegistered(this.GetType(), "main"))
                this.ClientScript.RegisterStartupScript(this.GetType(), "main", "<script type=\"text/javascript\" src=\"Scripts/Default.js\"></script>");
        }
    }
}
