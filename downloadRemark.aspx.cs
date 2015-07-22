using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;
using model;

public partial class _Default : System.Web.UI.Page
{
    filesManage FileMng = new filesManage();
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = int.Parse(Request.QueryString["fileid"]);
        datalstRemark.DataSource = FileMng.GetFileRemark(id);
        datalstRemark.DataBind();
        lblTips.Text = "查看文件<font style=\"color: Red\">" + FileMng.GetFile(id).Rows[0][1].ToString() + "</font>的评论";
    }
    protected void Page_Error(object sender, EventArgs e)
    {
        Response.Write("<script>alert('You are trying to hack my website ？');window.close();</script>");
        Server.ClearError();
    }
}
