using System;
using System.IO;
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

public partial class VXer_WebMng_Default : System.Web.UI.Page
{
    fileTypeManage FileTypeMng = new fileTypeManage();
    filesManage FileMng = new filesManage();
    static DataTable tab = new DataTable();
    static bool IsAll = true;

    protected void BindFileType()
    {   // 绑定文件类型
        droplstFileType.DataSource = FileTypeMng.GetFileTypes();
        droplstFileType.DataTextField = "fileType";
        droplstFileType.DataValueField = "id";
        droplstFileType.DataBind();
    }

    protected void BindKindFiles(int typeId)
    {   // 同类文件
        grdFiles.DataSource = null;
        grdFiles.DataBind();
        tab = FileMng.GetKindFiles(typeId);
        grdFiles.DataSource = tab;
        grdFiles.DataBind();
    }

    protected void BindAllFiles()
    {   // 所有文件
        grdFiles.DataSource = null;
        grdFiles.DataBind();
        tab = FileMng.GetAllFiles();
        grdFiles.DataSource = tab;
        grdFiles.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindFileType();
            BindAllFiles();
        }
    }
    protected void grdFiles_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = int.Parse(grdFiles.DataKeys[e.RowIndex][0].ToString());
        File.Delete(Server.MapPath("../VXer_upload_file/") + grdFiles.DataKeys[e.RowIndex][1].ToString());
        FileMng.DelFile(id);
        BindAllFiles();
    }
    protected void grdFiles_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFiles.PageIndex = e.NewPageIndex;
        if (IsAll)
            BindAllFiles();
        else
            BindKindFiles(int.Parse(droplstFileType.SelectedValue));
    }

    protected void droplstFileType_SelectedIndexChanged(object sender, EventArgs e)
    {   // 绑定所选类型的文件 
        IsAll = false;
        BindKindFiles(int.Parse(droplstFileType.SelectedValue));
    }
}
