using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class VXer_WebMng_vxer_admin : System.Web.UI.MasterPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if ("false" == Session["ad_islog"].ToString())
            Response.Redirect("../vxer_come.aspx");
    }
}
