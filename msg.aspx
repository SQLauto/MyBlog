<%@ Page Title="留言板" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true"
    CodeFile="msg.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function btnRemark_onclick() {
            window.open("newmsg.aspx", "newwindow", "height=280,width=500");
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td>
                <asp:DataList ID="datalstMsgs" runat="server">
                    <HeaderTemplate>
                        <table style="font-size: 13px;" border="0" cellspacing="0" cellpadding="0" width="100%">
                            <tr style="background-color: Black; color: White;">
                                <td style="width: 100px">
                                    留言IP
                                </td>
                                <td style="width: 780px">
                                    留言内容
                                </td>
                                <td style="width: 120px">
                                    留言时间
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
                        </table>
                    </FooterTemplate>
                </asp:DataList>
            </td>
            <tr>
                <td colspan="3" style="text-align: right;">
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
                    <input style="height: 20px; width: 80px;" id="btnRemark" type="button" onclick="return btnRemark_onclick()"
                        value="我要留言" />
                </td>
            </tr>
        </tr>
    </table>
</asp:Content>
