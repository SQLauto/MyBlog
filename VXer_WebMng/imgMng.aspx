<%@ Page Language="C#" MasterPageFile="~/VXer_WebMng/vxer_admin.master" AutoEventWireup="true"
    CodeFile="imgMng.aspx.cs" Inherits="VXer_WebMng_Default2" Title="图片管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">


function cbtnTypeMng_onclick() {
window.open("imgtypemng.aspx", "newwindow", "height=300,width=450");
}

function cbtnNewAtc_onclick() {
window.open("newimg.aspx");
}

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td style="width: 150px; text-align: center;">
                图片类型
            </td>
            <td colspan="2" style="text-align: left;">
                <asp:DropDownList ID="droplstImgType" runat="server" AutoPostBack="True" OnDataBound="droplstImgType_DataBound"
                    OnSelectedIndexChanged="droplstImgType_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <input style="height: 20px;" id="cbtnTypeMng" type="button" value="类型管理" onclick="return cbtnTypeMng_onclick()" />
                <input style="height: 20px;" id="cbtnNewAtc" type="button" value="上传图片" onclick="return cbtnNewAtc_onclick()" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDelImg" runat="server" Text="删除该图片" Height="20px" Width="100px"
                    OnClick="btnDelImg_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblTip" runat="server" Font-Size="14px" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px;">
                <asp:ListBox ID="lstImgs" runat="server" Font-Size="13px" ForeColor="#009900" Height="400px"
                    Width="100%" AutoPostBack="True" OnSelectedIndexChanged="lstImgs_SelectedIndexChanged"
                    OnDataBound="lstImgs_DataBound"></asp:ListBox>
            </td>
            <td colspan="2" style="width: 600px; height: 400px;">
                <asp:Label ID="lblImg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
            </td>
        </tr>
    </table>
</asp:Content>
