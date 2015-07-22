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

public partial class VXer_WebMng_Default2 : System.Web.UI.Page
{
    articleTypeManage ArcTypeMng = new articleTypeManage();
    articlesManage AtcMng = new articlesManage();

    protected void BindArcType()
    {
        droplstAtcType.DataSource = ArcTypeMng.GetAllArticleType();
        droplstAtcType.DataTextField = "articleType";
        droplstAtcType.DataValueField = "id";
        droplstAtcType.DataBind();
    }

    protected void BindGrdViewAllAtc()
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
            BindArcType();
            BindGrdViewAllAtc();
        }
    }

    protected void droplstAtcType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindGrdView(int.Parse(droplstAtcType.SelectedValue));
    }

    protected void grdAtcs_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (AtcMng.DeleteArticle(int.Parse(grdAtcs.DataKeys[e.RowIndex][0].ToString())))
            BindGrdViewAllAtc();
        else
            Response.Write("<script>alert('删除失败 ！');</script>");
    }
    protected void grdAtcs_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdAtcs.PageIndex = e.NewPageIndex;
        BindGrdViewAllAtc();
    }
}
