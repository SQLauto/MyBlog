<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newfile.aspx.cs" Inherits="VXer_WebMng_newfile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>文件上传</title>

    <script type="text/javascript">
function btnClose_onclick() {
window.close();
}

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <table style="font-size: 14px;" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="text-align: left;" colspan="2">
                <img src="../images/file_upload.jpg" />
            </td>
        </tr>
        <tr>
            <td style="width: 80px; text-align: center;">
                文件名称
            </td>
            <td>
                <asp:TextBox ID="txtFileName" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 80px; text-align: center;">
                所属分类
            </td>
            <td>
                <asp:DropDownList ID="dropFileType" runat="server" Width="156px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 80px; text-align: center;">
                选择文件
            </td>
            <td>
                <asp:FileUpload ID="fileup" runat="server" Width="228px" />
            </td>
            <td>
            </td>
        </tr>
        <tr style="padding-top: 3px">
            <td>
            </td>
            <td>
                <asp:Button ID="btnUp" runat="server" Text="确定" Height="21px" Width="50px" OnClick="btnUp_Click" />
                &nbsp;
                <input style="height: 21px; width: 50px" id="btnClose" type="button" value="关闭" onclick="return btnClose_onclick()" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="lblTip" runat="server" Font-Size="13px" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
