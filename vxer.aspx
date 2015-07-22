<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="vxer.aspx.cs"
    Inherits="_Default" Title="welcome to lazycat's website" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        a:visited, a:link
        {
            text-decoration: none;
            color: Blue;
        }
        a:hover
        {
            font-size: 14px;
            text-decoration: underline;
            background-color: Black;
            color: White;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td style="width: 500px">
                <asp:GridView ID="grdTopAtc" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
                    GridLines="Vertical" CaptionAlign="Left" DataKeyNames="id" Font-Size="14px" HorizontalAlign="Left"
                    PageSize="15">
                    <FooterStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="title" HeaderText="文章标题">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Left" VerticalAlign="Middle" Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="createTime" HeaderText="发表时间">
                            <ItemStyle Font-Size="13px" ForeColor="Blue" HorizontalAlign="Center" VerticalAlign="Middle"
                                Width="120px" />
                        </asp:BoundField>
                        <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="atcview.aspx?atcid={0}"
                            HeaderText="操作" Target="_blank" Text="点击浏览">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                        </asp:HyperLinkField>
                    </Columns>
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Black" Font-Bold="False" ForeColor="White" Font-Size="13px"
                        HorizontalAlign="Center" VerticalAlign="Middle" />
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                </asp:GridView>
            </td>
            <td>
                <table style="height: 160px; background-color: #f1edcc" border="0" cellspacing="0"
                    cellpadding="0" width="100%">
                    <tr>
                        <td style="font-size: 13px; text-align: center; color: White; background-color: Black"
                            colspan="3">
                            最新资源下载
                        </td>
                    </tr>
                    <asp:Repeater ID="rptFiles" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td style="font-size: 13px; border-bottom-style: solid; border-bottom-width: 1px;
                                    border-bottom-color: Red">
                                    <a target="_blank" href="downcount.aspx?fileid=<%#DataBinder.Eval(Container.DataItem, "id") %>">
                                        <%#DataBinder.Eval(Container.DataItem, "fileName") %></a>
                                </td>
                                <td style="color: #ab3a3a; font-size: 13px; border-bottom-style: solid; border-bottom-width: 1px;
                                    border-bottom-color: Red">
                                    <%#DataBinder.Eval(Container.DataItem, "fileType")%>
                                </td>
                                <td style="color: #101ae6; font-size: 13px; border-bottom-style: solid; border-bottom-width: 1px;
                                    border-bottom-color: Red">
                                    <%#DataBinder.Eval(Container.DataItem, "createTime")%>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                <table style="background-color: White" border="0" cellspacing="0" cellpadding="0"
                    width="100%">
                    <tr>
                        <td style="font-size: 13px; text-align: center; color: White; background-color: Black"
                            colspan="3">
                            最新上传图片
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 168px">
                            <asp:Label ID="lblImg" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
