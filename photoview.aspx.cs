using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;

public partial class _Default : System.Web.UI.Page
{
    imgTypeManage ImgTypeMng = new imgTypeManage();
    imgManage ImgMng = new imgManage();
    static DataTable tab = new DataTable();

    protected void BindImgType()
    {
        droplstImgType.DataSource = ImgTypeMng.GetImgType();
        droplstImgType.DataTextField = "imgType";
        droplstImgType.DataValueField = "id";
        droplstImgType.DataBind();
        lblTip.Text = "&nbsp;&nbsp;当前共有图片分类&nbsp;" + ImgTypeMng.GetTypeKinds().ToString() + "&nbsp;种&nbsp;&nbsp;&nbsp;&nbsp;共有图片&nbsp;" + ImgMng.GetImgCounts().ToString() + "&nbsp;张";
    }

    // 获取一种类型的图片到List Box
    protected void BindImgs(int typeid)
    {
        tab = ImgMng.GetKindImg(typeid);
        lstImgs.DataSource = tab;
        lstImgs.DataTextField = "imgName";
        lstImgs.DataValueField = "id";
        lstImgs.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindImgType();
        }
    }
    protected void ShowImage(int index)
    {
        // height: 400  width: 600 
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
        double x = 0; // 缩放比率
        if (h > 400)
        {

            x = double.Parse(h.ToString()) / (double)400;
            h = 400;
            w = (int)(double.Parse(w.ToString()) / x);
        }
        if (w > 600)
        {
            x = double.Parse(w.ToString()) / (double)600;
            w = 600;
            h = (int)(double.Parse(h.ToString()) / x);
        }
        strImg = strImg.Replace("height=" + height, "height=" + h.ToString());
        strImg = strImg.Replace("width=" + width, "width=" + w.ToString());
        lblImg.Text = strImg;
    }

    protected void droplstImgType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindImgs(int.Parse(droplstImgType.SelectedValue));
    }
    protected void droplstImgType_DataBound(object sender, EventArgs e)
    {
        BindImgs(int.Parse(droplstImgType.Items[0].Value));
    }
    protected void lstImgs_DataBound(object sender, EventArgs e)
    {
        if (0 != lstImgs.Items.Count)
            ShowImage(0);
    }
    protected void lstImgs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (-1 != lstImgs.SelectedIndex)
            ShowImage(lstImgs.SelectedIndex);
    }
}
