using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using bll;

public partial class VXer_WebMng_imgtypemng : System.Web.UI.Page
{
    imgTypeManage ImgTypeMng = new imgTypeManage();

    protected void BindAllImgTypes()
    {
        grdImgTypes.DataSource = null;
        grdImgTypes.DataBind();
        grdImgTypes.DataSource = ImgTypeMng.GetImgType();
        grdImgTypes.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindAllImgTypes();
    }
    protected void grdImgTypes_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        ImgTypeMng.UpdateImgType(int.Parse(grdImgTypes.DataKeys[e.RowIndex][0].ToString()), ((TextBox)grdImgTypes.Rows[e.RowIndex].Cells[0].Controls[0]).Text);
        grdImgTypes.EditIndex = -1;
        BindAllImgTypes();
    }
    protected void grdImgTypes_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdImgTypes.EditIndex = e.NewEditIndex;
        BindAllImgTypes();
    }
    protected void grdImgTypes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (ImgTypeMng.DelImgType(int.Parse(grdImgTypes.DataKeys[e.RowIndex][0].ToString())))
            BindAllImgTypes();
    }
    protected void grdImgTypes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdImgTypes.EditIndex = -1;
        BindAllImgTypes();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (ImgTypeMng.AddImgType(txtTypeName.Text.Trim()))
            BindAllImgTypes();
    }
}
