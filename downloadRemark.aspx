<%@ Page Title="查看评论" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true"
    CodeFile="downloadRemark.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function btnRemark_onclick() {
            var id = "<%=id %>";
            window.open("newremark.aspx?rmktype=file&atcid=" + id, "newwindow", "height=250,width=500");
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <tr>
        <td style="text-align: center; width: 1000px;">
            <asp:Label Width="100%" BackColor="#d3cbcb" ID="lblTips" Font-Size="14px" runat="server" ></asp:Label>
        </td>
    </tr>
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td>
                <asp:DataList ID="datalstRemark" runat="server">
                    <HeaderTemplate>
                        <table style="font-size: 13px;" border="0" cellspacing="0" cellpadding="0" width="100%">
                            <tr style="background-color: Black; color: White;">
                                <td style="width: 100px">
                                    评论IP
                                </td>
                                <td style="width: 780px">
                                    评论内容
                                </td>
                                <td style="width: 120px">
                                    评论时间
                                </td>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="width: 100px; color: Blue;">
                                <%#DataBinder.Eval(Container.DataItem, "userIP")%>
                            </td>
                            <td style="width: 800px;">
                                <%#DataBinder.Eval(Container.DataItem, "remark") %>
                            </td>
                            <td style="width: 100px; color: Red;">
                                <%#DataBinder.Eval(Container.DataItem, "createTime")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <tr>
                            <td colspan="3">
                                <hr style="color: Blue; height: 2px; width: 1000px; text-align: center;" />
                            </td>
                        </tr>
                    </SeparatorTemplate>
                    <FooterTemplate>
                        <tr>
                            <td colspan="3">
                                <hr style="color: Blue; height: 2px; width: 1000px; text-align: center;" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: right;">
                                <input style="height: 20px; width: 80px;" id="btnRemark" type="button" onclick="return btnRemark_onclick()"
                                    value="发表评论" />
                            </td>
                        </tr>
                        </table>
                    </FooterTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>
