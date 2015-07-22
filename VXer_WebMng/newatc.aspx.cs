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

public partial class VXer_WebMng_newatc : System.Web.UI.Page
{
    static bool IsNew = true;
    static int id;

    articleTypeManage AtcTypeMng = new articleTypeManage();
    articlesManage AtcMng = new articlesManage();

    protected void BindArcType()
    {
        droplstAtcType.DataSource = AtcTypeMng.GetAllArticleType();
        droplstAtcType.DataTextField = "articleType";
        droplstAtcType.DataValueField = "id";
        droplstAtcType.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                id = int.Parse(Request.QueryString["atcid"]);
                DataTable tab = AtcMng.GetArticle(id);
                txtTitle.Text = tab.Rows[0][1].ToString();
                txtMain.Text = tab.Rows[0][2].ToString();
                droplstAtcType.SelectedValue = tab.Rows[0][3].ToString();
                IsNew = false;
            }
            catch
            {
                IsNew = true;
            }
            BindArcType();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (IsNew)
        {
            Article atc = new Article();
            atc.Title = txtTitle.Text.Trim();
            atc.MainContent = txtMain.Text;
            atc.TypeId = int.Parse(droplstAtcType.SelectedItem.Value);
            int id = AtcMng.AddArticle(atc);
            if (null != id)
                Response.Redirect("../atcview.aspx?atcid=" + id.ToString());
            else
                Response.Write("<script>alert('文章添加失败 ！');</script>");
        }
        else
        {
            Article atc = new Article();
            atc.Id = id;
            atc.Title = txtTitle.Text.Trim();
            atc.MainContent = txtMain.Text;
            atc.TypeId = int.Parse(droplstAtcType.SelectedItem.Value);
            if (AtcMng.UpdateArticle(atc))
            {
                Response.Redirect("../atcview.aspx?atcid=" + id.ToString());
            }
            else
                Response.Write("<script>alert('更新失败 ！');</script>");
        }

    }
}
