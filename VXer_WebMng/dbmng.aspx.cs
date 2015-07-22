using System;
using System.IO;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class VXer_WebMng_Default : System.Web.UI.Page
{
    dbManage DbMng = new dbManage();
    protected void BindGrd()
    {
        grdBkFiles.DataSource = null;
        grdBkFiles.DataBind();
        grdBkFiles.DataSource = DbMng.GetAllbaks();
        grdBkFiles.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindGrd();
    }
    protected void btnBackAll_Click(object sender, EventArgs e)
    {
        string bkpath = Server.MapPath("../VXer_db_bak/") + DateTime.Now.ToString().Replace(':', '_') + ".bak";
        if (DbMng.BackupDb(bkpath))
            BindGrd();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        string bkpath = Server.MapPath("../VXer_db_bak/") + DateTime.Now.ToString().Replace(':', '_') + ".bak";
        if (DbMng.BackupDifrtDb(bkpath))
            BindGrd();
    }
    protected void grdBkFiles_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = int.Parse(grdBkFiles.DataKeys[e.RowIndex][0].ToString());
        if (DbMng.DelBak(id))
        {
            File.Delete(grdBkFiles.DataKeys[e.RowIndex][1].ToString());
            BindGrd();
        }
    }
    protected void grdBkFiles_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if ("resume" == e.CommandName)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (DbMng.ResumeDb(grdBkFiles.DataKeys[index][1].ToString()))
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "scs", "<script>alert('数据库恢复成功 !');</script>");
            else
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "fld", "<script>alert('数据库恢复失败 !');</script>");
        }
    }

}
