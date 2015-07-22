using System;
using System.Threading;
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

public partial class _Default : System.Web.UI.Page
{
    articlesManage AtcMng = new articlesManage();
    filesManage FileMng = new filesManage();
    imgManage ImgMng = new imgManage();
    static DataTable tab = new DataTable();

    protected void BindAtcs()
    {
        grdTopAtc.DataSource = AtcMng.GetTopTenAtc();
        grdTopAtc.DataBind();
    }
    protected void BindFiles()
    {
        rptFiles.DataSource = FileMng.GetTopFiles();
        rptFiles.DataBind();
    }

    protected void ShowImage()
    {
        string strHtml = "<marquee direction=\"right\" onmouseover=stop() onmouseout=start()>";
        tab = ImgMng.GetTopImgs();
        for (int index = 0; index < 5; index++)
        {
            string strImg = tab.Rows[index][3].ToString();
            int heightIndex = strImg.IndexOf("height=") + 7;
            int widthIndex = strImg.IndexOf("width=") + 6;
            string height = "", width = "";
            while (strImg[heightIndex] != ' ')
                height += strImg[heightIndex++];
            while (strImg[widthIndex] != ' ')
                width += strImg[widthIndex++];
            int h = int.Parse(height);
            int w = int.Parse(width);
            double x = 0;
            if (h > 168)
            {

                x = double.Parse(h.ToString()) / (double)168;
                h = 168;
                w = (int)(double.Parse(w.ToString()) / x);
            }
            if (w > 330)
            {
                x = double.Parse(w.ToString()) / (double)330;
                w = 330;
                h = (int)(double.Parse(h.ToString()) / x);
            }
            strImg = strImg.Replace("height=" + height, "height=" + h.ToString());
            strImg = strImg.Replace("width=" + width, "width=" + w.ToString());
            strHtml += strImg + "&nbsp;&nbsp;&nbsp;&nbsp;";
        }
        strHtml += "</marquee>";
        strHtml = strHtml.Replace("</P>", "</span>");
        strHtml = strHtml.Replace("<P align=center>", "<span align=center>");
        lblImg.Text = strHtml;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAtcs();
            BindFiles();
            ShowImage();
        }
    }
}
