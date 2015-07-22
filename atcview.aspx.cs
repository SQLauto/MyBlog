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

public partial class atcview : System.Web.UI.Page
{
    articlesManage AtcMng = new articlesManage();
    public string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            id = Request.QueryString["atcid"];
            AtcMng.AddViewCount(int.Parse(id));
            DataTable tab = AtcMng.GetArticle(int.Parse(Request.QueryString["atcid"]));
            lblTitle.Text = tab.Rows[0][1].ToString();
            lblMain.Text = tab.Rows[0][2].ToString();
            lblInfo.Text = "发表时间: " + tab.Rows[0][4].ToString() + "    所属类别: " + tab.Rows[0][6].ToString() + "    评论条数: " + AtcMng.GetAtcRmks(int.Parse(id)).ToString();
        }
    }
    protected void Page_Error(object sender, EventArgs e)
    {
        Response.Write("<script>alert('You are trying to hack my website ？');window.close();</script>");
        Server.ClearError();
    }
}
