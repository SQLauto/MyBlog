<%@ Page Title="图片查看" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true"
    CodeFile="photoview.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td colspan="3" style="text-align: left;">
                <img src="images/img_type.jpg" />
                <asp:DropDownList ID="droplstImgType" runat="server" AutoPostBack="True" OnDataBound="droplstImgType_DataBound"
                    OnSelectedIndexChanged="droplstImgType_SelectedIndexChanged" Width="150px">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblTip" runat="server" Font-Size="14px" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; text-align: center;">
                <asp:ListBox ID="lstImgs" runat="server" Font-Size="13px" ForeColor="Blue" Height="400px"
                    Width="150px" AutoPostBack="True" OnSelectedIndexChanged="lstImgs_SelectedIndexChanged"
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
