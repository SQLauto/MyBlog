using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class downcount : System.Web.UI.Page
{
    filesManage FileMng = new filesManage();

    protected void Page_Error(object sender, EventArgs e)
    {
        Response.Write("<script>alert('You are trying to hack my website ？');window.close();</script>");
        Server.ClearError();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["fileid"].Trim());
        FileMng.AddDownCount(id);
        Response.Redirect("./VXer_upload_file/" + FileMng.GetFile(id).Rows[0][3].ToString());
    }
}
