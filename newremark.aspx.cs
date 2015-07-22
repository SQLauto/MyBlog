using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;
using model;

public partial class newremark : System.Web.UI.Page
{
    articlesManage AtcMng = new articlesManage();
    filesManage FileMng = new filesManage();

    static int id;
    static bool IsFileRmk = false; // 评论类型

    protected void Page_Error(object sender, EventArgs e)
    {
        if (Server.GetLastError() is HttpRequestValidationException)
        {
            Response.Write("<script>alert('You are trying to hack my website ？');window.close();</script>");
            Server.ClearError();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        if (!IsPostBack)
        {
            try
            {
                if (Request.QueryString[0] == "file")
                    IsFileRmk = true;
                else
                    IsFileRmk = false;
            }
            catch
            {
                IsFileRmk = false;
            }

            id = int.Parse(Request.QueryString["atcid"]);
            if (IsFileRmk)
            {
                string title = FileMng.GetFile(id).Rows[0][1].ToString();
                lblInfo.Text = "请你发表对文件<font style=\"color: Red\">" + title + "</font>的评论";
            }
            else
            {
                string title = AtcMng.GetArticle(id).Rows[0][1].ToString();
                lblInfo.Text = "请你发表对文章<font style=\"color: Red\">" + title + "</font>的评论";
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblTip.Text = "";
        try
        {
            if (txtRemark.Text.Trim() == "")
            {
                lblTip.Text = "验证失败或内容为空 ！";
                return;
            }
        }
        catch
        {
            lblTip.Text = "验证失败或内容为空 ！";
            return;
        }
        Remark rmk = new Remark();
        rmk.AtcId = id;
        rmk.UserIP = Request.UserHostAddress;
        rmk.RemarkText = txtRemark.Text.Replace("\r\n", "<br/>");
        if (IsFileRmk)
        {
            if (FileMng.AddFileRemark(rmk))
                Response.Write("<script>alert('您的评论已经成功提交 ！');window.close();</script>");
            else
                lblTip.Text = "文件评论提交失败 ！";
        }
        else
        {
            if (AtcMng.AddRemark(rmk))
                Response.Write("<script>alert('您的评论已经成功提交 ！');window.close();</script>");
            else
                lblTip.Text = "文章评论提交失败 ！";
        }

    }
}
