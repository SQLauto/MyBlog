<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newimg.aspx.cs" Inherits="VXer_WebMng_newimg"
    ValidateRequest="false" %>

<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片上传</title>
    <style type="text/css">
        .banner
        {
            width: 1000px;
            margin-left: auto;
            margin-right: auto;
        }
        .main
        {
            width: 1000px;
            height: 480px;
            margin-left: auto;
            margin-right: auto;
            color: White;
            background-color: InfoText;
        }
        .copyright
        {
            float: none;
            margin-top: 30px;
            width: 1000px;
            margin-left: auto;
            margin-right: auto;
            text-align: center;
            font-family: "新宋体";
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="banner">
        <img src="../images/banner.jpg" />
    </div>
    <div class="main">
        <table border="0" cellspacing="0" cellpadding="0" width="100%">
            <tr>
                <td style="width: 80px; text-align: center">
                    图片标题
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtTitle" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <FTB:FreeTextBox ID="txtMain" runat="Server" Width="1000px" ButtonSet="OfficeMac"
                        ImageGalleryPath="../VXer_upload_img" ToolbarLayout="ParagraphMenu,FontFacesMenu,FontSizesMenu,FontForeColorsMenu|Bold,Italic,Underline,Strikethrough;Superscript,Subscript,RemoveFormat|JustifyLeft,JustifyRight,JustifyCenter,JustifyFull;BulletedList,NumberedList,Indent,Outdent;CreateLink,Unlink,InsertImage,InsertRule|Cut,Copy,Paste;Undo,Redo,Print,InsertImageFromGallery" />
                </td>
            </tr>
            <tr>
                <td style="width: 80px; text-align: center">
                    所属分类
                </td>
                <td style="text-align: left">
                    <asp:DropDownList ID="droplstImgType" runat="server" Width="150px">
                    </asp:DropDownList>
                </td>
                <td style="text-align: left">
                    <asp:Button ID="btnSave" runat="server" Height="20px" Width="35px" Text="上传" 
                        Style="margin-left: 0px" onclick="btnSave_Click" />
                </td>
            </tr>
        </table>
    </div>
    </div>
    <div class="copyright">
        <hr />
        版权所有(C)VXer E-Mail: vxer@qq.com<br />
        未经作者许可不得以任何方式任何用途转载本站内容
    </div>
    </form>
</body>
</html>
