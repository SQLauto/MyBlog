<%@ Page Title="留言管理" Language="C#" MasterPageFile="~/VXer_WebMng/vxer_admin.master"
    AutoEventWireup="true" CodeFile="msgmng.aspx.cs" Inherits="VXer_WebMng_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%" style="background-color: Black;">
        <tr>
            <td>
                <asp:DataList ID="datalstMsgs" runat="server" Width="785px" OnItemCommand="datalstMsgs_ItemCommand">
                    <HeaderTemplate>
                        <table style="font-size: 13px;" border="0" cellspacing="0" cellpadding="0" width="100%">
                            <tr style="background-color: Black; color: White;">
                                <td style="width: 100px">
                                    留言IP
                                </td>
                                <td style="width: 250px">
                                    留言内容
                                </td>
                                <td style="width: 100px">
                                    留言时间
                                </td>
                                <td style="width: 50px">
                                    操作
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <hr style="color: White; height: 2px; width: 785px; text-align: center;" />
                                </td>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="width: 50px; color: White;">
                                <asp:Label ID="lblId" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "id") %>' Visible="false"></asp:Label>
                                <%#DataBinder.Eval(Container.DataItem, "userIP")%>
                            </td>
                            <td style="width: 300px;">
                                <%#DataBinder.Eval(Container.DataItem, "remark") %>
                            </td>
                            <td style="width: 100px; color: White;">
                                <%#DataBinder.Eval(Container.DataItem, "createTime")%>
                            </td>
                            <td>
                                <asp:Button ID="btnDel" CommandName="del" runat="server" Height="20px" Width="50px"
                                    Text="删除" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        <tr>
                            <td colspan="4">
                                <hr style="color: White; height: 2px; width: 785px; text-align: center;" />
                            </td>
                        </tr>
                    </SeparatorTemplate>
                    <FooterTemplate>
                        <tr>
                            <td colspan="4">
                                <hr style="color: White; height: 2px; width: 785px; text-align: center;" />
                            </td>
                        </tr>
                        </table>
                    </FooterTemplate>
                </asp:DataList>
            </td>
            <tr>
                <td colspan="4" style="text-align: right; background-color: White">
                    <asp:Label ID="lblPage" runat="server" Font-Size="14px" ForeColor="Blue"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">首页</asp:LinkButton>
                    &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtnPrev" runat="server" OnClick="lbtnPrev_Click">上一页</asp:LinkButton>
                    &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtnNext" runat="server" OnClick="lbtnNext_Click">下一页</asp:LinkButton>
                    &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtnLast" runat="server" OnClick="lbtnLast_Click">尾页</asp:LinkButton>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                </td>
            </tr>
        </tr>
    </table>
</asp:Content>
