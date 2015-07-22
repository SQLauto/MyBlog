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

public partial class _Default : System.Web.UI.Page
{
    articlesManage AtcMng = new articlesManage();
    articleTypeManage AtcTypeMng = new articleTypeManage();
    protected void BindAtcType()
    {
        droplstFileType.DataSource = AtcTypeMng.GetAllArticleType();
        droplstFileType.DataTextField = "articleType";
        droplstFileType.DataValueField = "id";
        droplstFileType.DataBind();
    }
    protected void BindAllAtcs()
    {
        grdAtcs.DataSource = null;
        grdAtcs.DataBind();
        grdAtcs.DataSource = AtcMng.GetAllArticles();
        grdAtcs.DataBind();
    }
    protected void BindGrdView(int id)
    {
        grdAtcs.DataSource = null;
        grdAtcs.DataBind();
        grdAtcs.DataSource = AtcMng.GetArticles(id);
        grdAtcs.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAllAtcs();
            BindAtcType();
        }
    }
    protected void Page_Error(object sender, EventArgs e)
    {
        if (Server.GetLastError() is HttpRequestValidationException)
        {
            Response.Write("<script>alert('请不要输入非法字符 ！');window.close();</script>");
            Server.ClearError();
        }
    }
    protected void grdAtcs_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdAtcs.PageIndex = e.NewPageIndex;
        BindAllAtcs();
    }
    protected void droplstFileType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGrdView(int.Parse(droplstFileType.SelectedValue));
    }
    protected void imgbtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        grdAtcs.DataSource = null;
        grdAtcs.DataBind();
        grdAtcs.DataSource = AtcMng.SearchArticle(txtKeyword.Text.Trim());
        grdAtcs.DataBind();
    }
}
