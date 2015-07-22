<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newmsg.aspx.cs" Inherits="newmsg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>留言板</title>

    <script type="text/javascript">

        function btnClose_onclick() {
            window.close();
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <table style="text-align: center;" border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtMsg" runat="server" Height="100px" TextMode="MultiLine" 
                    Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAsk" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/vldt_asr.jpg" />
                <asp:TextBox ID="txtAsr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="margin-top: 3px;">
                <asp:Button ID="btnOK" runat="server" Text="提交留言" Height="20px" Width="80px" 
                    onclick="btnOK_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <input id="btnClose" type="button" value="关闭窗口" style="height: 20px; width: 80px" onclick="return btnClose_onclick()" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/lvmsg.jpg" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTip" runat="server" Font-Size="13px" ForeColor="Blue"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
