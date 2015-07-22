using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class newmsg : System.Web.UI.Page
{
    messageManage MsgMng = new messageManage();
    static int num1, num2;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            num1 = rnd.Next(0, 999);
            num2 = rnd.Next(0, 999);
            lblAsk.Text = num1.ToString() + " + " + num2.ToString() + " = ?";
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblTip.Text = "";
        try
        {
            if (txtMsg.Text.Trim() == "" || (num1 + num2) != int.Parse(txtAsr.Text.Trim()))
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
        if (MsgMng.AddMsg(Request.UserHostAddress, txtMsg.Text.Replace("\r\n", "<br/>")))
            Response.Write("<script>alert('您的留言已经成功提交 ！');window.close();</script>");
        else
            lblTip.Text = "验证失败或内容为空 ！";
    }
}
