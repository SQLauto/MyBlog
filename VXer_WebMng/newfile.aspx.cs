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
using model;

public partial class VXer_WebMng_newfile : System.Web.UI.Page
{
    fileTypeManage FileTypeMng = new fileTypeManage();
    filesManage FileMng = new filesManage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dropFileType.DataSource = FileTypeMng.GetFileTypes();
            dropFileType.DataTextField = "fileType";
            dropFileType.DataValueField = "id";
            dropFileType.DataBind();
        }
    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        lblTip.Text = "";
        try
        {
            string fileName = fileup.FileName;
            string ext = Path.GetExtension(fileName).ToLower(); // 扩展名判断
            if (ext == ".asp" || ext == ".aspx" || ext == ".js" || ext == ".html")
            {
                lblTip.Text = "非法文件格式 ！";
                return;
            }
            string SavaFolder = Server.MapPath("../VXer_upload_file/");
            string filepath = SavaFolder + fileName;
            if (File.Exists(filepath))
            {   // 若服务器存在同名文件则将文件名改为系统当前时间
                fileName = DateTime.Now.ToString() + ext;
                fileName = fileName.Replace(':', '_');
                filepath = SavaFolder + fileName;
            }
            fileup.SaveAs(filepath);
            UploadFile UpFile = new UploadFile();
            UpFile.FileName = txtFileName.Text.Trim();
            UpFile.TypeId = int.Parse(dropFileType.SelectedValue);
            UpFile.FilePath = fileName;
            if (FileMng.AddFile(UpFile))
                lblTip.Text = "文件上传非常成功 ！";
            else
                lblTip.Text = "文件上传失败 ！";
        }
        catch
        {
            lblTip.Text = "文件上传失败 ！";
        }

    }
}
