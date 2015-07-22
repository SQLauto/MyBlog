<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="diarylist.aspx.cs"
    Inherits="_Default" Title="日志列表" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 1000px; font-size: 13px; text-align: left; vertical-align: middle;">
                <img src="images/atc_type.jpg" /><asp:DropDownList ID="droplstFileType" runat="server"
                    Width="150px" AutoPostBack="True" OnSelectedIndexChanged="droplstFileType_SelectedIndexChanged">
                </asp:DropDownList>
                <img src="images/atc_search.jpg" />
                <asp:TextBox ID="txtKeyword" runat="server" Width="200px">请在此输入关键字</asp:TextBox>
                &nbsp;
                <asp:ImageButton ID="imgbtnSearch" runat="server" 
                    ImageUrl="~/images/search.jpg" onclick="imgbtnSearch_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 1000px">
                <asp:GridView ID="grdAtcs" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
                    GridLines="Vertical" HorizontalAlign="Left" DataKeyNames="id" AllowPaging="True"
                    OnPageIndexChanging="grdAtcs_PageIndexChanging" PageSize="20">
                    <FooterStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField HeaderText="文章标题" DataField="title">
                            <ItemStyle Width="450px" HorizontalAlign="Left" VerticalAlign="Middle" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发布时间" DataField="createTime">
                            <ItemStyle Width="120px" HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="所属分类" DataField="articleType">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="viewTimes" HeaderText="浏览次数">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:HyperLinkField HeaderText="文章预览" Text="点此预览" DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/atcview.aspx?atcid={0}"
                            Target="_blank">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" Font-Size="13px" />
                        </asp:HyperLinkField>
                        <asp:HyperLinkField HeaderText="评论信息" Text="查看评论" DataNavigateUrlFields="id" 
                            DataNavigateUrlFormatString="viewRemark.aspx?atcid={0}" Target="_blank">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:HyperLinkField>
                    </Columns>
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" Font-Size="13px"
                        Height="15px" VerticalAlign="Middle" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Font-Size="13px" />
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
