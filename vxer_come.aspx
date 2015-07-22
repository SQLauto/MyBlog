<%@ Page Language="C#" AutoEventWireup="true" CodeFile="vxer_come.aspx.cs" Inherits="vxer_come" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VXer Login</title>
    <style type="text/css">
        .banner
        {
            width: 1000px;
            margin-left: auto;
            margin-right: auto;
        }
        .navigate
        {
            margin-left: auto;
            margin-right: auto;
            width: 1000px;
            text-align: left;
        }
        .main
        {
            margin-left: auto;
            margin-right: auto;
            width: 1000px;
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
            font-size: 13px;
        }
        .aimg
        {
            border-width: 0px;
            padding-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="banner">
        <img src="images/banner.jpg" />
    </div>
    <table style="text-align: center; margin-top: 50px;" border="0" cellspacing="0"
        cellpadding="0" width="100%">
        <tr>
            <td>
                <img src="images/wlcmadmin.jpg" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/username.gif" />
                <asp:TextBox ID="txtName" runat="server" Height="20px" Width="200px" 
                    MaxLength="12"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/password.gif" />
                <asp:TextBox ID="txtPwd" runat="server" Height="20px" Width="200px" 
                    MaxLength="12" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnLog" runat="server" ImageUrl="~/images/Login.jpg" 
                    onclick="imgbtnLog_Click" style="height: 30px" />
            </td>
        </tr>
    </table>
    <div class="copyright">
        <hr />
        版权所有(C)VXer E-Mail: vxer@qq.com<br />
        未经作者许可不得以任何方式任何用途转载本站内容
    </div>
    </form>
</body>
</html>
