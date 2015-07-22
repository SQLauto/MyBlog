using System;
using System.Text;
using System.Web.Security;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class vxer_come : System.Web.UI.Page
{
    adminManage AdMng = new adminManage();
    protected void imgbtnLog_Click(object sender, ImageClickEventArgs e)
    {
        if (AdMng.CheckLogin(txtName.Text, FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text, "md5")))
        {
            Session["ad_islog"] = "true";
            Response.Redirect("VXer_WebMng/atcmng.aspx");
        }
    }
}
