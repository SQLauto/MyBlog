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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindFiles();
    }
    protected void BindFiles()
    {
        grdFiles.DataSource = FileMng.GetAllFiles();
        grdFiles.DataBind();
    }
    protected void grdFiles_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFiles.PageIndex = e.NewPageIndex;
        BindFiles();
    }
}
