<%@ Page Title="数据备份与还原" Language="C#" MasterPageFile="~/VXer_WebMng/vxer_admin.master"
    AutoEventWireup="true" CodeFile="dbmng.aspx.cs" Inherits="VXer_WebMng_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td style="width: 50px; text-align: center;">
            </td>
            <td style="width: 100px; text-align: center;">
            </td>
            <td>
                <asp:Button ID="btnBackAll" runat="server" Text="立即完全备份" Height="20px" 
                    onclick="btnBackAll_Click" Width="100px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnBack" runat="server" Visible="false" Text="立即差异备份" Height="20px"
                    onclick="btnBack_Click" Width="100px" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 2px;">
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grdBkFiles" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                    CellPadding="3" ForeColor="Black"
                    GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="id,bakFile" AllowPaging="True"
                    PageSize="17" onrowcommand="grdBkFiles_RowCommand" 
                    onrowdeleting="grdBkFiles_RowDeleting">
                    <FooterStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField HeaderText="备份文件" DataField="bakFile">
                            <ItemStyle Width="350px" HorizontalAlign="Left" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备份方式" DataField="bakType">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="备份时间" DataField="createTime">
                            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:ButtonField HeaderText="操作" Text="恢复至此" CommandName="resume">
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:ButtonField>
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                        </asp:CommandField>
                    </Columns>
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" Font-Size="13px"
                        Height="15px" VerticalAlign="Middle" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
