<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newremark.aspx.cs" Inherits="newremark" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>发表评论</title>

    <script type="text/javascript">

        function btnClose_onclick() {
            window.close();
        }
    </script>

    <style type="text/css">
        .main
        {
            margin-left: auto;
            margin-right: auto;
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main" style="height: 20px; width: 80px">
        <table style="text-align: center;" border="0" cellspacing="0" cellpadding="0" width="100%">
            <tr>
                <td>
                    <asp:Label ID="lblInfo" runat="server" Font-Size="13px" ForeColor="Blue"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtRemark" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="margin-top: 3px;">
                    <asp:Button ID="btnOK" runat="server" Text="提交评论" Height="20px" Width="80px" OnClick="btnOK_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="btnClose" type="button" value="关闭窗口" style="height: 20px; width: 80px"
                        onclick="return btnClose_onclick()" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTip" runat="server" Font-Size="13px" ForeColor="Blue"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
