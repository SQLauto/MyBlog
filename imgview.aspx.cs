using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using bll;

public partial class imgview : System.Web.UI.Page
{
    imgManage ImgMng = new imgManage();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int imgid = int.Parse(Request.QueryString["imgid"].ToString());
            DataTable tab = ImgMng.GetImg(imgid);
            lblTitle.Text = tab.Rows[0][2].ToString();
            lblMain.Text = tab.Rows[0][3].ToString();
        }
        catch
        {
            Response.Redirect("errorWarn.htm");
        }
        
    }
}
