<%@ Page Language="C#" AutoEventWireup="true" CodeFile="imgtypemng.aspx.cs" Inherits="VXer_WebMng_imgtypemng" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片类型管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left; width: 500px;">
        <table border="0" cellspacing="0" cellpadding="0" width="100%">
            <tr>
                <td colspan="3">
                    <asp:GridView ID="grdImgTypes" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                        CellPadding="3" ForeColor="Black"
                        GridLines="Vertical" DataKeyNames="id" 
                        onrowcancelingedit="grdImgTypes_RowCancelingEdit" 
                        onrowdeleting="grdImgTypes_RowDeleting" onrowediting="grdImgTypes_RowEditing" 
                        onrowupdating="grdImgTypes_RowUpdating">
                        <FooterStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField HeaderText="类型名称" DataField="imgType">
                                <HeaderStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" Font-Size="13px"
                                    Height="23px" />
                            </asp:BoundField>
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                                <HeaderStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="80px"
                                    Height="23px" />
                            </asp:CommandField>
                            <asp:CommandField ShowEditButton="True" CausesValidation="False">
                                <ControlStyle Font-Size="13px" />
                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px"
                                    Height="23px" />
                            </asp:CommandField>
                        </Columns>
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                    </asp:GridView>
                </td>
            </tr>
            <tr style="height: 23px; font-size: 13px;">
                <td colspan="3" style="text-align: center;">
                    新建类型
                    <asp:TextBox ID="txtTypeName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                        ControlToValidate="txtTypeName"></asp:RequiredFieldValidator>
                    <asp:Button ID="btnAdd" runat="server" Text="添加" Height="20px" Width="50px" OnClick="btnAdd_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
