using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class VXer_WebMng_Default : System.Web.UI.Page
{
    messageManage MsgMng = new messageManage();
    static PagedDataSource pds = new PagedDataSource();
    static int pageindex = 0;

    protected void BindMsgs()
    {
        pds.DataSource = MsgMng.GetAllMsgs().DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 10;
        pds.CurrentPageIndex = pageindex;
        lblPage.Text = "当前第&nbsp;" + (pds.CurrentPageIndex + 1).ToString() + "&nbsp;页 &nbsp; &nbsp; &nbsp;共&nbsp;" + pds.PageCount.ToString() + "&nbsp;页 &nbsp; &nbsp; &nbsp;&nbsp;";
        datalstMsgs.DataSource = pds;
        datalstMsgs.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindMsgs();
    }
    protected void lbtnFirst_Click(object sender, EventArgs e)
    {   // 首页
        pageindex = 0;
        BindMsgs();
    }
    protected void lbtnPrev_Click(object sender, EventArgs e)
    {   // 上一页
        if (pds.CurrentPageIndex != 0)
        {
            pageindex--;
            BindMsgs();
        }
    }
    protected void lbtnNext_Click(object sender, EventArgs e)
    {   // 下一页
        if (pds.CurrentPageIndex != pds.PageCount - 1)
        {
            pageindex++;
            BindMsgs();
        }
    }
    protected void lbtnLast_Click(object sender, EventArgs e)
    {   // 尾页
        pageindex = pds.PageCount - 1;
        BindMsgs();
    }
    protected void datalstMsgs_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int id = int.Parse(((Label)e.Item.FindControl("lblId")).Text);
            if (MsgMng.DelMsg(id))
                BindMsgs();
        }
    }
}
