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

public partial class VXer_WebMng_atctypemng : System.Web.UI.Page
{
    articleTypeManage AtcTypeMng = new articleTypeManage();
    protected void BindAllAtcTypes()
    {
        grdAtcTypes.DataSource = null;
        grdAtcTypes.DataBind();
        grdAtcTypes.DataSource = AtcTypeMng.GetAllArticleType();
        grdAtcTypes.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindAllAtcTypes();
    }

    protected void grdAtcTypes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (AtcTypeMng.DelArticleType(int.Parse(grdAtcTypes.DataKeys[e.RowIndex][0].ToString())))
            BindAllAtcTypes();
    }
    protected void grdAtcTypes_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdAtcTypes.EditIndex = e.NewEditIndex;
        BindAllAtcTypes();
    }
    protected void grdAtcTypes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdAtcTypes.EditIndex = -1;
        BindAllAtcTypes();
    }
    protected void grdAtcTypes_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        AtcTypeMng.UpdateArticleType(int.Parse(grdAtcTypes.DataKeys[e.RowIndex][0].ToString()), ((TextBox)grdAtcTypes.Rows[e.RowIndex].Cells[0].Controls[0]).Text);
        grdAtcTypes.EditIndex = -1;
        BindAllAtcTypes();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (AtcTypeMng.AddArticleType(txtTypeName.Text.Trim()))
            BindAllAtcTypes();
    }

    protected void grdAtcTypes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdAtcTypes.PageIndex = e.NewPageIndex;
        BindAllAtcTypes();
    }
}
