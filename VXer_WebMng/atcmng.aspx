<%@ Page Language="C#" MasterPageFile="~/VXer_WebMng/vxer_admin.master" AutoEventWireup="true"
    CodeFile="atcmng.aspx.cs" Inherits="VXer_WebMng_Default2" Title="文章管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
function cbtnNewAtc_onclick() {
window.open("newatc.aspx");
}

function cbtnTypeMng_onclick() {
window.open("atctypemng.aspx", "newwindow", "height=300,width=450");
}

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td colspan="3" style="text-align: center;">
                选择不同类型查看其下所有文章
            </td>
        </tr>
        <tr>
            <td style="width: 50px; text-align: center;">
                文章类型
            </td>
            <td style="width: 100px; text-align: center;">
                <asp:DropDownList ID="droplstAtcType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="droplstAtcType_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <input style="height: 20px;" id="cbtnTypeMng" type="button" value="类型管理" onclick="return cbtnTypeMng_onclick()" />
                <input style="height: 20px;" id="cbtnNewAtc" type="button" value="发表文章" onclick="return cbtnNewAtc_onclick()" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 2px;">
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grdAtcs" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
                    GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="id" OnRowDeleting="grdAtcs_RowDeleting"
                    AllowPaging="True" OnPageIndexChanging="grdAtcs_PageIndexChanging" PageSize="17">
                    <FooterStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField HeaderText="文章标题" DataField="title">
                            <ItemStyle Width="300px" HorizontalAlign="Left" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="发布时间" DataField="createTime">
                            <ItemStyle Width="120px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="所属分类" DataField="articleType">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:HyperLinkField HeaderText="文章预览" Text="点此预览" DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/atcview.aspx?atcid={0}"
                            Target="_blank">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:HyperLinkField>
                        <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="~/VXer_WebMng/newatc.aspx?atcid={0}"
                            HeaderText="编辑" Target="_blank" Text="点此编辑">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:HyperLinkField>
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
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
