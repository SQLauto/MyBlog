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

public partial class VXer_WebMng_filetypemng : System.Web.UI.Page
{
    fileTypeManage FileTypeMng = new fileTypeManage();

    protected void BindAllFileTypes()
    {
        grdFileTypes.DataSource = null;
        grdFileTypes.DataBind();
        grdFileTypes.DataSource = FileTypeMng.GetFileTypes();
        grdFileTypes.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindAllFileTypes();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (FileTypeMng.AddFileType(txtTypeName.Text.Trim()))
            BindAllFileTypes();
    }
    protected void grdFileTypes_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        FileTypeMng.UpdateFileType(int.Parse(grdFileTypes.DataKeys[e.RowIndex][0].ToString()), ((TextBox)grdFileTypes.Rows[e.RowIndex].Cells[0].Controls[0]).Text);
        grdFileTypes.EditIndex = -1;
        BindAllFileTypes();
    }
    protected void grdFileTypes_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdFileTypes.EditIndex = e.NewEditIndex;
        BindAllFileTypes();
    }
    protected void grdFileTypes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdFileTypes.EditIndex = -1;
        BindAllFileTypes();
    }
    protected void grdFileTypes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (FileTypeMng.DelFileType(int.Parse(grdFileTypes.DataKeys[e.RowIndex][0].ToString())))
            BindAllFileTypes();
    }
}
