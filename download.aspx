<%@ Page Title="资源下载" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true"
    CodeFile="download.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 1000px">
                <asp:GridView ID="grdFiles" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow"
                    BorderColor="Tan" BorderWidth="1px" 
                    CellPadding="2" ForeColor="Black"
                    GridLines="None" HorizontalAlign="Left" DataKeyNames="id" AllowPaging="True"
                    OnPageIndexChanging="grdFiles_PageIndexChanging" PageSize="20">
                    <FooterStyle BackColor="Tan" />
                    <Columns>
                        <asp:BoundField HeaderText="文件标题" DataField="fileName">
                            <ItemStyle Width="450px" HorizontalAlign="Left" VerticalAlign="Middle" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发布时间" DataField="createTime">
                            <ItemStyle Width="120px" HorizontalAlign="Center" VerticalAlign="Middle" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="文件类型" DataField="fileType">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" Font-Size="13px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="downCount" HeaderText="下载次数">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:HyperLinkField HeaderText="文件下载" Text="点击下载" 
                            DataNavigateUrlFields="id" DataNavigateUrlFormatString="downcount.aspx?fileid={0}"
                            Target="_blank">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" Font-Size="13px" />
                        </asp:HyperLinkField>
                        <asp:HyperLinkField HeaderText="评论信息" Text="查看评论" DataNavigateUrlFields="id" 
                            DataNavigateUrlFormatString="downloadRemark.aspx?fileid={0}" 
                            Target="_blank">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:HyperLinkField>
                    </Columns>
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                        HorizontalAlign="Center" Font-Size="13px"
                        Height="15px" VerticalAlign="Middle" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" Font-Size="13px" />
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
