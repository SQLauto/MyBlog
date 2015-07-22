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
using model;

public partial class VXer_WebMng_newimg : System.Web.UI.Page
{
    imgTypeManage ImgTypeMng = new imgTypeManage();
    imgManage ImgMng = new imgManage();

    protected void btnSave_Click(object sender, EventArgs e)
    {
        model.Image img = new model.Image();
        img.ImgName = txtTitle.Text.Trim();
        img.ImgPath = txtMain.Text;
        img.TypeId = int.Parse(droplstImgType.SelectedValue);
        Response.Redirect("../imgview.aspx?imgid="+ImgMng.AddImg(img).ToString());
    }
    protected void BindImgType()
    {
        droplstImgType.DataSource = ImgTypeMng.GetImgType();
        droplstImgType.DataTextField = "imgType";
        droplstImgType.DataValueField = "id";
        droplstImgType.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindImgType();
        }
    }
}
