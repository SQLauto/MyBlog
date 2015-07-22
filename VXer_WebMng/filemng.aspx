<%@ Page Language="C#" MasterPageFile="~/VXer_WebMng/vxer_admin.master" AutoEventWireup="true"
    CodeFile="filemng.aspx.cs" Inherits="VXer_WebMng_Default" Title="文件管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
    
function cbtnNewFile_onclick() {
window.open("newfile.aspx", "newwindow", "height=200,width=420");
}

function cbtnTypeMng_onclick() {
window.open("filetypemng.aspx", "newwindow", "height=300,width=450");
}

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td colspan="3" style="text-align: center;">
                选择不同类型查看其下所有文件
            </td>
        </tr>
        <tr>
            <td style="width: 50px; text-align: center;">
                文件类型
            </td>
            <td style="width: 100px; text-align: center;">
                <asp:DropDownList ID="droplstFileType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="droplstFileType_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <input style="height: 20px;" id="cbtnTypeMng" type="button" value="类型管理" onclick="return cbtnTypeMng_onclick()" />
                <input style="height: 20px;" id="cbtnNewFile" type="button" value="上传文件" onclick="return cbtnNewFile_onclick()" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 2px;">
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grdFiles" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
                    GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="id,filePath" AllowPaging="True"
                    PageSize="17" OnPageIndexChanging="grdFiles_PageIndexChanging" OnRowDeleting="grdFiles_RowDeleting">
                    <FooterStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField HeaderText="文件名称" DataField="fileName">
                            <ItemStyle Width="300px" HorizontalAlign="Left" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="上传时间" DataField="createTime">
                            <ItemStyle Width="120px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="所属分类" DataField="fileType">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="下载次数" DataField="downCount">
                            <ItemStyle Font-Size="13px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                        </asp:BoundField>
                        <asp:HyperLinkField DataNavigateUrlFields="filePath" DataNavigateUrlFormatString="../VXer_upload_file/{0}"
                            HeaderText="下载" Target="_blank" Text="点此下载">
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
